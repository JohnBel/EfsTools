using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using EfsTools.Qualcomm;
using EfsTools.Qualcomm.QcdmCommands.Requests.Efs;
using EfsTools.Qualcomm.QcdmCommands.Responses.Efs;
using EfsTools.Resourses;
using NWebDav.Server;
using NWebDav.Server.Http;
using NWebDav.Server.Locking;
using NWebDav.Server.Props;
using NWebDav.Server.Stores;

namespace EfsTools.WebDAV
{
    internal sealed class EfsStoreCollection : IStoreCollection
    {
        public static EfsStoreCollection Create(QcdmManager manager, string name, string uniqueKey, string path,
            bool isReadOnly, Logger logger, LogLevel logLevel)
        {
            var item = new EfsStoreCollection(manager, name, uniqueKey, path, isReadOnly, logger, logLevel);
            item.Initialize();
            return item;
        }

        private EfsStoreCollection(QcdmManager manager, string name, string uniqueKey, string path, bool isReadOnly,
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
            var items = EfsFileManager.Instance.GetEntries(_manager, _path);
            
            if (items != null)
            {
                var files = items.Where((entry => entry.EntryType != DirectoryEntryType.Directory)).ToArray();
                _propertyManager = new PropertyManager<EfsStoreCollection>(
                    new DavProperty<EfsStoreCollection>[]
                    {
                        // RFC-2518 properties
                        new DavCreationDate<EfsStoreCollection>
                        {
                            Getter = (context, collection) => DateTimeOffset.FromUnixTimeSeconds(stat.CreateTime).UtcDateTime,
                            Setter = (context, collection, value) =>
                            {
                                return DavStatusCode.Ok;
                            }
                        },
                        new DavDisplayName<EfsStoreCollection>
                        {
                            Getter = (context, collection) => collection.Name
                        },
                        new DavGetLastModified<EfsStoreCollection>
                        {
                            Getter = (context, collection) => DateTimeOffset.FromUnixTimeSeconds(stat.ModifyTime).UtcDateTime,
                            Setter = (context, collection, value) =>
                            {
                                return DavStatusCode.Ok;
                            }
                        },
                        new DavGetResourceType<EfsStoreCollection>
                        {
                            Getter = (context, collection) => new[] { _davCollection }
                        },
                        new DavLockDiscoveryDefault<EfsStoreCollection>(),
                        new DavSupportedLockDefault<EfsStoreCollection>(),
                        new DavExtCollectionChildCount<EfsStoreCollection>
                        {
                            Getter = (context, collection) => items.Length
                        },
                        new DavExtCollectionIsFolder<EfsStoreCollection>
                        {
                            Getter = (context, collection) => true
                        },
                        new DavExtCollectionIsHidden<EfsStoreCollection>
                        {
                            Getter = (context, collection) => false
                        },
                        new DavExtCollectionIsStructuredDocument<EfsStoreCollection>
                        {
                            Getter = (context, collection) => false
                        },
                        new DavExtCollectionHasSubs<EfsStoreCollection>
                        {
                            Getter = (context, collection) => items.Length > files.Length
                        },
                        new DavExtCollectionNoSubs<EfsStoreCollection>
                        {
                            Getter = (context, collection) => false
                        },
                        new DavExtCollectionObjectCount<EfsStoreCollection>
                        {
                            Getter = (context, collection) => files.Length
                        },
                        new DavExtCollectionReserved<EfsStoreCollection>
                        {
                            Getter = (context, collection) => _isReadOnly
                        },
                        new DavExtCollectionVisibleCount<EfsStoreCollection>
                        {
                            Getter = (context, collection) => items.Length
                        },

                        // Win32 extensions
                        new Win32CreationTime<EfsStoreCollection>
                        {
                            Getter = (context, collection) => DateTimeOffset.FromUnixTimeSeconds(stat.CreateTime).UtcDateTime,
                            Setter = (context, collection, value) =>
                            {
                                return DavStatusCode.Ok;
                            }
                        },
                        new Win32LastAccessTime<EfsStoreCollection>
                        {
                            Getter = (context, collection) => DateTimeOffset.FromUnixTimeSeconds(stat.AccessTime).UtcDateTime,
                            Setter = (context, collection, value) =>
                            {
                                return DavStatusCode.Ok;
                            }
                        },
                        new Win32LastModifiedTime<EfsStoreCollection>
                        {
                            Getter = (context, collection) => DateTimeOffset.FromUnixTimeSeconds(stat.ModifyTime).UtcDateTime,
                            Setter = (context, collection, value) =>
                            {
                                return DavStatusCode.Ok;
                            }
                        },
                        new Win32FileAttributes<EfsStoreCollection>
                        {
                            Getter = (context, collection) => _isReadOnly 
                                ? FileAttributes.Directory | FileAttributes.Normal | FileAttributes.ReadOnly
                                : FileAttributes.Directory | FileAttributes.Normal,
                            Setter = (context, collection, value) =>
                            {
                                return DavStatusCode.Ok;
                            }
                        }

                    });
            }
        }
    

        public string Name { get => _name; }
        public string UniqueKey { get => _uniqueKey; }
        // Disk collections (a.k.a. directories don't have their own data)
        public Task<Stream> GetReadableStreamAsync(IHttpContext httpContext) => Task.FromResult((Stream)null);
        public Task<DavStatusCode> UploadFromStreamAsync(IHttpContext httpContext, Stream inputStream) => Task.FromResult(DavStatusCode.Conflict);
        public Task<StoreItemResult> CopyAsync(IStoreCollection destination, string name, bool overwrite, IHttpContext httpContext)
        {
            return null;
        }
        public IPropertyManager PropertyManager { get => _propertyManager; }
        public ILockingManager LockingManager { get; private set; }
        public Task<IStoreItem> GetItemAsync(string name, IHttpContext httpContext)
        {
            return Task.Run(() =>
            {
                try
                {
                    var fullPath = _path == "/" ? $"{_path}{name}" : $"{_path}/{name}";
                    LogInfo(Strings.WebDavGetItemFormat, fullPath);
                    if (EfsFileManager.Instance.IsDirectory(_manager, fullPath))
                    {
                        return (IStoreItem)EfsStoreCollection.Create(_manager, name, fullPath, fullPath,
                            _isReadOnly, _logger, _logLevel);
                    }

                    return (IStoreItem)EfsStoreItem.Create(_manager, name, fullPath, fullPath,
                        _isReadOnly, _logger, _logLevel);
                }
                catch (Exception ex)
                {
                    var fullPath = _path == "/" ? $"{_path}{name}" : $"{_path}/{name}";
                    LogError(Strings.WebDavErrorGetItemFormat, fullPath, ex.Message);
                    return (IStoreItem)null;
                }
            });
        }

        public Task<IList<IStoreItem>> GetItemsAsync(IHttpContext httpContext)
        {
            return Task.Run(() =>
            {
                try
                {
                    LogInfo(Strings.WebDavGetItemsFormat, _path);
                    var items = new List<IStoreItem>();
                    var efsItems = EfsFileManager.Instance.GetEntries(_manager, _path);
                    foreach (var efsItem in efsItems)
                    {
                        var path = _path == "/" ? $"{_path}{efsItem.Name}" : $"{_path}/{efsItem.Name}";
                        if (efsItem.EntryType == DirectoryEntryType.Directory)
                        {
                            items.Add(EfsStoreCollection.Create(_manager, efsItem.Name, path, path, _isReadOnly,
                                _logger, _logLevel));
                        }
                        else
                        {
                            items.Add(EfsStoreItem.Create(_manager, efsItem.Name, path, path, _isReadOnly,
                                _logger, _logLevel));
                        }
                    }

                    return (IList<IStoreItem>)items;
                }
                catch (Exception ex)
                {
                    LogError(Strings.WebDavErrorGetItemsFormat, _path, ex.Message);
                    return new List<IStoreItem>(0);
                }
            });
        }

        Task<IEnumerable<IStoreItem>> IStoreCollection.GetItemsAsync(IHttpContext httpContext)
        {
            try
            {
                LogInfo(Strings.WebDavGetItemsFormat, _path);

                var items = new List<IStoreItem>();
                var efsItems = EfsFileManager.Instance.GetEntries(_manager, _path);

                foreach (var efsItem in efsItems)
                {
                    var path = _path == "/" ? $"{_path}{efsItem.Name}" : $"{_path}/{efsItem.Name}";

                    if (efsItem.EntryType == DirectoryEntryType.Directory)
                    {
                        items.Add(EfsStoreCollection.Create(_manager, efsItem.Name, path, path, _isReadOnly, _logger, _logLevel));
                    }
                    else
                    {
                        items.Add(EfsStoreItem.Create(_manager, efsItem.Name, path, path, _isReadOnly, _logger, _logLevel));
                    }
                }

                return Task.FromResult<IEnumerable<IStoreItem>>(items);
            }
            catch (Exception ex)
            {
                LogError(Strings.WebDavErrorGetItemsFormat, _path, ex.Message);
                return Task.FromResult(Enumerable.Empty<IStoreItem>());
            }
        }

        public Task<StoreItemResult> CreateItemAsync(string name, bool overwrite, IHttpContext httpContext)
        {
            return Task.Run(() =>
            {
                try
                {
                    var destinationPath = _path == "/" ? $"{_path}{name}" : $"{_path}/{name}";
                    LogInfo(Strings.WebDavCreateItemFormat, destinationPath);
                    if (_isReadOnly)
                    {
                        return new StoreItemResult(DavStatusCode.PreconditionFailed);
                    }
                    var result = DavStatusCode.NoContent; ;
                    if (overwrite && _manager.Efs.FileExists(destinationPath))
                    {
                        _manager.Efs.DeleteFile(destinationPath);
                    }

                    using (var file = _manager.Efs.OpenFile(destinationPath, EfsFileFlag.Create, 0777))
                    {
                        file.Open();
                        result = DavStatusCode.Created;
                        file.Close();
                    }

                    EfsFileManager.Instance.UpdateEntries(_manager, _path);

                    return new StoreItemResult(result, EfsStoreItem.Create(_manager, name,
                        destinationPath,
                        destinationPath, _isReadOnly, _logger, _logLevel));
                }
                catch (Exception ex)
                {
                    LogError(Strings.WebDavErrorCreateItemFormat, _path, ex.Message);
                    return new StoreItemResult(DavStatusCode.InternalServerError);
                }
            });
        }

        public Task<StoreCollectionResult> CreateCollectionAsync(string name, bool overwrite, IHttpContext httpContext)
        {
            return Task.Run(() =>
            {
                try
                {
                    var destinationPath = _path == "/" ? $"{_path}{name}" : $"{_path}/{name}";
                    LogInfo(Strings.WebDavCreateCollectionFormat, destinationPath);
                    if (_isReadOnly)
                    {
                        return new StoreCollectionResult(DavStatusCode.PreconditionFailed);
                    }
                    DavStatusCode result;
                    _manager.Efs.CreateDirectory(destinationPath, 0777);
                    result = DavStatusCode.Created;
                    EfsFileManager.Instance.UpdateEntries(_manager, _path);
                    return new StoreCollectionResult(result, EfsStoreCollection.Create(_manager, name,
                        destinationPath,
                        destinationPath, _isReadOnly, _logger, _logLevel));
                }
                catch (Exception ex)
                {
                    LogError(Strings.WebDavErrorCreateCollectionFormat, _path, ex.Message);
                    return new StoreCollectionResult(DavStatusCode.InternalServerError);
                }
            });
        }

        public bool SupportsFastMove(IStoreCollection destination, string destinationName, bool overwrite, IHttpContext httpContext)
        {
            return false;
        }

        public Task<StoreItemResult> MoveItemAsync(string sourceName, IStoreCollection destination, string destinationName, bool overwrite,
            IHttpContext httpContext)
        {
            return Task.Run(() =>
            {
                try
                {
                    var destinationPath = _path == "/" ? $"{_path}{sourceName}" : $"{_path}/{sourceName}";
                    LogInfo(Strings.WebDavMoveItemFormat, destinationPath);
                    if (_isReadOnly)
                    {
                        return new StoreItemResult(DavStatusCode.PreconditionFailed);
                    }

                    return new StoreItemResult(DavStatusCode.NotImplemented);
                }
                catch (Exception ex)
                {
                    LogError(Strings.WebDavErrorMoveItemFormat, sourceName, ex.Message);
                    return new StoreItemResult(DavStatusCode.InternalServerError);
                }
            });
        }

        public Task<DavStatusCode> DeleteItemAsync(string name, IHttpContext httpContext)
        {
            return Task.Run(() =>
            {
                try
                {
                    var fullPath = _path == "/" ? $"{_path}{name}" : $"{_path}/{name}";
                    LogInfo(Strings.WebDavDeleteItemFormat, fullPath);
                    if (_isReadOnly)
                    {
                        return DavStatusCode.PreconditionFailed;
                    }
                    if (EfsFileManager.Instance.IsDirectory(_manager, fullPath))
                    {
                        _manager.Efs.DeleteDirectory(fullPath);
                    }
                    else
                    {
                        _manager.Efs.DeleteFile(fullPath);
                    }
                    EfsFileManager.Instance.UpdateEntries(_manager, _path);
                    return DavStatusCode.Ok;
                }
                catch (Exception ex)
                {
                    LogError(Strings.WebDavErrorDeleteItemFormat, name, ex.Message);
                    return DavStatusCode.InternalServerError;
                }
            });
        }

        public InfiniteDepthMode InfiniteDepthMode { get; }

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
        private PropertyManager<EfsStoreCollection> _propertyManager;
        private readonly string _name;
        private readonly string _uniqueKey;
        private readonly string _path;
        private readonly bool _isReadOnly;
        private readonly Logger _logger;
        private readonly LogLevel _logLevel;
        private static readonly XElement _davCollection = new XElement(WebDavNamespaces.DavNs + "collection");
    }
}