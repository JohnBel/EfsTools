using System;
using EfsTools.Qualcomm.QcdmCommands;
using EfsTools.Qualcomm.QcdmCommands.Requests.Efs;
using EfsTools.Qualcomm.QcdmCommands.Responses.Efs;

namespace EfsTools.Qualcomm.QcdmManagers
{
    internal class QcdmEfsManager
    {
        private readonly WeakReference<QcdmManager> _manager;

        private HelloInfo _helloInfo;

        public QcdmEfsManager(QcdmManager manager)
        {
            _manager = new WeakReference<QcdmManager>(manager);
        }

        public QueryInfo EfsInfo
        {
            get
            {
                InitializeIfNeed();
                if (_manager.TryGetTarget(out var manager))
                {
                    if (manager.IsOpen)
                    {
                        var request = new EfsQueryCommandRequest();
                        var response = (EfsQueryCommandResponse) manager.ExecuteQcdmCommandRequest(request);
                        return response.Info;
                    }
                }

                return null;
            }
        }

        public EfsDeviceInfo DeviceInfo
        {
            get
            {
                InitializeIfNeed();
                if (_manager.TryGetTarget(out var manager))
                {
                    if (manager.IsOpen)
                    {
                        var request = new EfsDeviceInfoCommandRequest();
                        var response = (EfsDeviceInfoResponse) manager.ExecuteQcdmCommandRequest(request);
                        return response.DeviceInfo;
                    }
                }

                return null;
            }
        }

        public HelloInfo HelloInfo
        {
            get
            {
                InitializeIfNeed();
                return _helloInfo;
            }
        }

        public QcdmEfsFileStream OpenFile(string filePath, EfsFileFlag flags, int permission)
        {
            if (_manager.TryGetTarget(out var manager))
            {
                var file = new QcdmEfsFileStream(manager, filePath, flags, permission);
                file.Open();
                return file;
            }

            return null;
        }

        public bool FileExists(string path)
        {
            InitializeIfNeed();
            try
            {
                if (_manager.TryGetTarget(out var manager))
                {
                    if (manager.IsOpen)
                    {
                        var request = new EfsStatFileCommandRequest(path);
                        var response = (EfsStatFileCommandResponse) manager.ExecuteQcdmCommandRequest(request);
                        var stat = response.Stat;
                        if (stat.Size > 0 || stat.LinkCount > 0)
                        {
                            return true;
                        }
                    }
                }

                return false;
            }
            catch
            {
                return false;
            }
        }

        public void RenameFile(string path, string newPath)
        {
            InitializeIfNeed();
            if (_manager.TryGetTarget(out var manager))
            {
                if (manager.IsOpen)
                {
                    var request = new EfsRenameFileCommandRequest(path, newPath);
                    var response = (EfsRenameFileCommandResponse) manager.ExecuteQcdmCommandRequest(request);
                    QcdmEfsErrorsUtils.ThrowQcdmEfsErrorsIfNeed(response.Error);
                }
            }
        }

        public FileStat FileStat(string path)
        {
            InitializeIfNeed();
            if (_manager.TryGetTarget(out var manager))
            {
                if (manager.IsOpen)
                {
                    var request = new EfsStatFileCommandRequest(path);
                    var response = (EfsStatFileCommandResponse) manager.ExecuteQcdmCommandRequest(request);
                    return response.Stat;
                }
            }

            return null;
        }

        public void CheckAccess(string path, byte permissionBits)
        {
            InitializeIfNeed();
            if (_manager.TryGetTarget(out var manager))
            {
                if (manager.IsOpen)
                {
                    var request = new EfsAccessCommandRequest(path, permissionBits);
                    var response = (EfsAccessCommandResponse) manager.ExecuteQcdmCommandRequest(request);
                    QcdmEfsErrorsUtils.ThrowQcdmEfsErrorsIfNeed(response.Error);
                }
            }
        }

        public QcdmEfsDirectory OpenDirectory(string path)
        {
            InitializeIfNeed();
            if (_manager.TryGetTarget(out var manager))
            {
                var directory = new QcdmEfsDirectory(manager, path);
                directory.Open();
                return directory;
            }

            return null;
        }

        public void CreateDirectory(string path, ushort mode)
        {
            InitializeIfNeed();
            if (_manager.TryGetTarget(out var manager))
            {
                var request = new EfsMakeDirectoryCommandRequest(mode, path);
                var response = (EfsMakeDirectoryCommandResponse) manager.ExecuteQcdmCommandRequest(request);
                if (response.Error != QcdmEfsErrors.DirectoryExist)
                {
                    QcdmEfsErrorsUtils.ThrowQcdmEfsErrorsIfNeed(response.Error);
                }
            }
        }

        public void DeleteDirectory(string path)
        {
            InitializeIfNeed();
            if (_manager.TryGetTarget(out var manager))
            {
                var request = new EfsRemoveDirectoryCommandRequest(path);
                var response = (EfsRemoveDirectoryCommandResponse) manager.ExecuteQcdmCommandRequest(request);
                QcdmEfsErrorsUtils.ThrowQcdmEfsErrorsIfNeed(response.Error);
            }
        }

        public void DeleteFile(string path)
        {
            InitializeIfNeed();
            if (_manager.TryGetTarget(out var manager))
            {
                var request = new EfsUnlinkFileCommandRequest(path);
                var response = (EfsUnlinkFileCommandResponse) manager.ExecuteQcdmCommandRequest(request);
                QcdmEfsErrorsUtils.ThrowQcdmEfsErrorsIfNeed(response.Error);
            }
        }

        public void SyncNoWait(string path, ushort sequence)
        {
            InitializeIfNeed();
            if (_manager.TryGetTarget(out var manager))
            {
                if (manager.IsOpen)
                {
                    var request = new EfsSyncNoWaitCommandRequest(path, sequence);
                    var response = (EfsSyncNoWaitCommandResponse) manager.ExecuteQcdmCommandRequest(request);
                    QcdmEfsErrorsUtils.ThrowQcdmEfsErrorsIfNeed(response.Error);
                }
            }
        }

        public void PutItemFile(string path, EfsFileFlag flags, int permission, byte[] data)
        {
            InitializeIfNeed();
            if (_manager.TryGetTarget(out var manager))
            {
                if (manager.IsOpen)
                {
                    var request = new EfsPutItemFileCommandRequest(path, flags, permission, data);
                    var response = (EfsPutItemFileCommandResponse) manager.ExecuteQcdmCommandRequest(request);
                    QcdmEfsErrorsUtils.ThrowQcdmEfsErrorsIfNeed(response.Error);
                }
            }
        }

        private void InitializeIfNeed()
        {
            if (_helloInfo == null)
            {
                if (_manager.TryGetTarget(out var manager))
                {
                    if (manager.IsOpen)
                    {
                        var request = new EfsHelloCommandRequest();
                        var response = (EfsHelloCommandResponse) manager.ExecuteQcdmCommandRequest(request);
                        _helloInfo = response.Info;
                    }
                }
            }
        }
    }
}