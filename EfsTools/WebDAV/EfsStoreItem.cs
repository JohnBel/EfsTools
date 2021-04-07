using System;
using System.IO;
using System.Security.Cryptography;
using System.Threading.Tasks;
using EfsTools.Qualcomm;
using EfsTools.Resourses;
using EfsTools.Utils;
using NWebDav.Server;
using NWebDav.Server.Helpers;
using NWebDav.Server.Http;
using NWebDav.Server.Locking;
using NWebDav.Server.Props;
using NWebDav.Server.Stores;

namespace EfsTools.WebDAV
{
    internal class EfsStoreItem : IStoreItem
    {
        public static EfsStoreItem Create(QcdmManager manager, string name, string uniqueKey, string path,
            bool isReadOnly, Logger logger, LogLevel logLevel)
        {
            var item = new EfsStoreItem(manager, name, uniqueKey, path, isReadOnly, logger, logLevel);
            item.Initialize();
            return item;
        }

        private EfsStoreItem(QcdmManager manager, string name, string uniqueKey, string path, bool isReadOnly,
            Logger logger, LogLevel logLevel)
        {
            _manager = manager;
            _name = name;
            _uniqueKey = uniqueKey;
            _path = path;
            _isReadOnly = isReadOnly;
            _logger = logger;
            _logLevel = logLevel;
            LockingManager = new EfsStoreLockingManager();
        }

        private void Initialize()
        {
            var stat = EfsFileManager.Instance.GetEntry(_manager, _path);
            
            _propertyManager = new PropertyManager<EfsStoreItem>(
                new DavProperty<EfsStoreItem>[]
                {
                    // RFC-2518 properties
                    new DavCreationDate<EfsStoreItem>
                    {
                        Getter = (context, item) => DateTimeOffset.FromUnixTimeSeconds(stat.CreateTime).UtcDateTime,
                        Setter = (context, item, value) =>
                        {
                            return DavStatusCode.Ok;
                        }
                    },
                    new DavDisplayName<EfsStoreItem>
                    {
                        Getter = (context, item) => item.Name
                    },
                    new DavGetContentLength<EfsStoreItem>
                    {
                        Getter = (context, item) => stat.Size
                    },
                    new DavGetContentType<EfsStoreItem>
                    {
                        Getter = (context, item) => item.DetermineContentType()
                    },
                    new DavGetEtag<EfsStoreItem>
                    {
                        // Calculating the Etag is an expensive operation,
                        // because we need to scan the entire file.
                        IsExpensive = true,
                        Getter = (context, item) => item.CalculateEtag()
                    },
                    new DavGetLastModified<EfsStoreItem>
                    {
                        Getter = (context, item) => DateTimeOffset.FromUnixTimeSeconds(stat.ModifyTime).UtcDateTime,
                        Setter = (context, item, value) =>
                        {
                            return DavStatusCode.Ok;
                        }
                    },
                    new DavGetResourceType<EfsStoreItem>
                    {
                        Getter = (context, item) => null
                    },
                    new DavLockDiscoveryDefault<EfsStoreItem>(),
                    new DavSupportedLockDefault<EfsStoreItem>(),
                    new DavExtCollectionIsHidden<EfsStoreItem>
                    {
                        Getter = (context, item) => false
                    },
                    // Win32 extensions
                    new Win32CreationTime<EfsStoreItem>
                    {
                        Getter = (context, collection) => DateTimeOffset.FromUnixTimeSeconds(stat.CreateTime).UtcDateTime,
                        Setter = (context, collection, value) =>
                        {
                            return DavStatusCode.Ok;
                        }
                    },
                    new Win32LastAccessTime<EfsStoreItem>
                    {
                        Getter = (context, collection) => DateTimeOffset.FromUnixTimeSeconds(stat.AccessTime).UtcDateTime,
                        Setter = (context, collection, value) =>
                        {
                            return DavStatusCode.Ok;
                        }
                    },
                    new Win32LastModifiedTime<EfsStoreItem>
                    {
                        Getter = (context, collection) => DateTimeOffset.FromUnixTimeSeconds(stat.ModifyTime).UtcDateTime,
                        Setter = (context, collection, value) =>
                        {
                            return DavStatusCode.Ok;
                        }
                    },
                    new Win32FileAttributes<EfsStoreItem>
                    {
                        Getter = (context, collection) => _isReadOnly 
                                ? FileAttributes.Normal | FileAttributes.ReadOnly
                                : FileAttributes.Normal,
                        Setter = (context, collection, value) =>
                        {
                            return DavStatusCode.Ok;
                        }
                    }

                });
        }

        private string CalculateEtag()
        {
            try
            {
                var stat = EfsFileManager.Instance.GetEntry(_manager, _path);
                if (stat.Mode == 0)
                {
                    return String.Empty;
                }

                using (var stream = FileUtils.PhoneOpenRead(_manager, _path))
                {
                    var hash = SHA256.Create().ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", string.Empty);
                }
            }
            catch (Exception ex)
            {
                LogError(Strings.WebDavErrorCalculationETagFormat, ex.Message);
                return String.Empty;
            }
        }

        private string DetermineContentType()
        {
            return MimeTypeHelper.GetMimeType(Name);
        }

        public string Name { get => _name; }
        public string UniqueKey { get => _uniqueKey; }
        public Task<Stream> GetReadableStreamAsync(IHttpContext httpContext)
        {
            return Task.Run(() =>
            {
                try
                {
                    LogInfo(Strings.WebDavGetReadableStreamFormat, _path);
                    var stat = EfsFileManager.Instance.GetEntry(_manager, _path);
                    if (stat.Mode == 0)
                    {
                        return Stream.Null;
                    }

                    var stream = FileUtils.PhoneOpenRead(_manager, _path);
                    return stream;
                }
                catch (Exception ex)
                {
                    LogError(Strings.WebDavErrorGetReadableStreamFormat, _path, ex.Message);
                    return Stream.Null;
                }
            });
        }

        public Task<DavStatusCode> UploadFromStreamAsync(IHttpContext httpContext, Stream source)
        {
            return Task.Run(() =>
            {
                try
                {
                    LogInfo(Strings.WebDavUploadFromStreamFormat, _path);
                    using (var output = FileUtils.PhoneCreateWrite(_manager, _path, 0777, _logger))
                    {
                        StreamUtils.Copy(source, output);
                        output.Flush();
                        output.Close();
                    }
                    return DavStatusCode.Ok;
                }
                catch (Exception ex)
                {
                    LogError(Strings.WebDavErrorUploadFromStreamFormat, _path, ex.Message);
                    return DavStatusCode.InternalServerError;
                }
            });
        }

        public Task<StoreItemResult> CopyAsync(IStoreCollection destination, string name, bool overwrite, IHttpContext httpContext)
        {
            return Task.Run(() =>
            {
                try
                {
                    LogInfo(Strings.WebDavCopyFormat, _path, name);
                    using (var input = FileUtils.PhoneOpenRead(_manager, _path))
                    {
                        var item = destination.CreateItemAsync(name, overwrite, httpContext).Result.Item;
                        var code = item.UploadFromStreamAsync(httpContext, input).Result;
                        return new StoreItemResult(code, item);
                    }
                }
                catch (Exception ex)
                {
                    LogError(Strings.WebDavErrorCopyStreamFormat, name, ex.Message);
                    return new StoreItemResult(DavStatusCode.InternalServerError, null);
                }
            });
        }

        public IPropertyManager PropertyManager { get => _propertyManager; }
        public ILockingManager LockingManager { get; private set; }

        private void LogInfo(string format, params object[] args)
        {
            if (_logger != null && _logLevel >= LogLevel.Info)
            {
                _logger.LogInfo(format, args);
            }
        }

        private void LogWarning(string format, params object[] args)
        {
            if (_logger != null && _logLevel >= LogLevel.Warning)
            {
                _logger.LogWarning(format, args);
            }
        }

        private void LogError(string format, params object[] args)
        {
            if (_logger != null && _logLevel >= LogLevel.Error)
            {
                _logger.LogError(format, args);
            }
        }

        private readonly QcdmManager _manager;
        private PropertyManager<EfsStoreItem> _propertyManager;
        private readonly string _name;
        private readonly string _uniqueKey;
        private readonly string _path;
        private bool _isReadOnly;
        private readonly Logger _logger;
        private readonly LogLevel _logLevel;
    }
}