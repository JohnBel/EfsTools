using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using EfsTools.Qualcomm;
using EfsTools.Resourses;
using NWebDav.Server.Http;
using NWebDav.Server.Stores;

namespace EfsTools.WebDAV
{
    internal sealed class EfsStore : IStore
    {
        public EfsStore(QcdmManager manager, bool readOnly, Logger logger, LogLevel logLevel)
        {
            _manager = manager;
            _readOnly = readOnly;
            _logger = logger;
            _logLevel = logLevel;
        }
        public Task<IStoreItem> GetItemAsync(Uri uri, IHttpContext httpContext)
        {
            LogInfo(Strings.WebDavProcessingItemRequestFormat, uri, httpContext.Request.HttpMethod);
            var path = uri.LocalPath;
            var name = Path.GetFileName(path);
            if (IsIgnoredFile(name))
            {
                return Task.FromResult((IStoreItem) null);
            }
            return Task.Run(() =>
            {
                try
                {
                    var stat = EfsFileManager.Instance.GetEntry(_manager, path);
                    if (stat.Mode == 0)
                    {
                        LogWarning(Strings.WebDavWarningPathNotFoundFormat, path);
                        return null;
                    }

                    if (EfsFileManager.Instance.IsDirectory(_manager, path))
                    {
                        var dirItem = EfsStoreCollection.Create(_manager, name, path, path, _readOnly, _logger, _logLevel);
                        return (IStoreItem) dirItem;
                    }

                    var item = EfsStoreItem.Create(_manager, name, path, path, _readOnly, _logger, _logLevel);
                    return (IStoreItem) item;
                }
                catch (Exception ex)
                {
                    LogError(Strings.WebDavErrorOnProcessItemRequestFormat, ex.Message);
                    return null;
                }
            });
 
        }

        public Task<IStoreCollection> GetCollectionAsync(Uri uri, IHttpContext httpContext)
        {
            LogInfo(Strings.WebDavProcessingCollectionRequestFormat, uri, httpContext.Request.HttpMethod);
            var path = uri.LocalPath;
            var name = Path.GetFileName(path);
            if (IsIgnoredFile(name))
            {
                return Task.FromResult((IStoreCollection)null);
            }
            return Task.Run(() =>
            {
                try
                {
                    var stat = EfsFileManager.Instance.GetEntry(_manager, path);
                    if (stat.Mode == 0)
                    {
                        LogWarning(Strings.WebDavWarningPathNotFoundFormat, path);
                        return null;
                    }

                    var item = EfsStoreCollection.Create(_manager, name, path, path, _readOnly, _logger, _logLevel);
                    return (IStoreCollection) item;
                }
                catch (Exception ex)
                {
                    LogError(Strings.WebDavErrorGetReadableStreamFormat, path, ex.Message);
                    return null;
                }
            });
        }

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

        private bool IsIgnoredFile(string name)
        {
            return _ignoredFiles.Contains(name);
        }

        private readonly QcdmManager _manager;
        private readonly bool _readOnly;
        private readonly Logger _logger;
        private readonly LogLevel _logLevel;
        private readonly HashSet<string> _ignoredFiles = new HashSet<string>(StringComparer.Ordinal){ "desktop.ini", ".git", "HEAD", "favicon.ico" };
    }
}
