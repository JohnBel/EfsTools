using System;
using System.IO;
using System.Linq;
using System.Text;
using EfsTools.Qualcomm;
using EfsTools.Qualcomm.QcdmCommands.Requests.Efs;
using EfsTools.Qualcomm.QcdmCommands.Responses.Efs;
using EfsTools.Resourses;

namespace EfsTools.Utils
{
    internal static class FileUtils
    {
        public static Stream LocalOpenRead(string path)
        {
            return File.Open(path, FileMode.Open, FileAccess.Read);
        }

        public static Stream LocalCreateWrite(string path)
        {
            var fixedPath = path.Replace("\n", "[LF]");
            fixedPath = fixedPath.Replace("\r", "[CR]");
            var directoryPath = Path.GetDirectoryName(fixedPath);
            if (directoryPath != null)
            {
                Directory.CreateDirectory(directoryPath);
            }

            return File.Create(fixedPath);
        }

        public static Stream PhoneOpenRead(QcdmManager manager, string path)
        {
            var file = manager.Efs.OpenFile(path, EfsFileFlag.Readonly, 0);
            return file;
        }

        public static Stream PhoneCreateWrite(QcdmManager manager, string path, int permission, Logger logger)
        {
            var efs = manager.Efs;
            if (efs.FileExists(path))
            {
                efs.DeleteFile(path);
            }

            var directoryPath = PathUtils.GetDirectoryName(path);
            if (!efs.FileExists(directoryPath))
            {
                PhoneCreateDirectory(manager, directoryPath, true, logger);
            }

            var file = manager.Efs.OpenFile(path, EfsFileFlag.Writeonly | EfsFileFlag.Create, permission);
            return file;
        }

        public static Stream PhoneItemOpenRead(QcdmManager manager, string path)
        {
            var file = manager.Efs.OpenFile(path, EfsFileFlag.Readonly, 0);
            return file;
        }

        public static Stream PhoneItemCreateWrite(QcdmManager manager, string path, int permission, Logger logger)
        {
            var efs = manager.Efs;
            if (efs.FileExists(path))
            {
                efs.DeleteFile(path);
            }

            var directoryPath = PathUtils.GetDirectoryName(path);
            if (!efs.FileExists(directoryPath))
            {
                PhoneCreateDirectory(manager, directoryPath, true, logger);
            }

            return new QcdmManagerItemWriteStreamAdapter(manager, path, permission);
        }

        public static void PhoneCreateDirectory(QcdmManager manager, string path, bool recursive, Logger logger)
        {
            if (!string.IsNullOrEmpty(path) && path != "/")
            {
                var p = path;
                if (p[p.Length - 1] == '/')
                {
                    p = p.Substring(0, p.Length - 1);
                }

                if (recursive)
                {
                    var ind = p.LastIndexOf('/');
                    if (ind > 0)
                    {
                        var parentPath = p.Substring(0, ind);
                        if (!string.IsNullOrEmpty(parentPath) && parentPath != "/")
                        {
                            PhoneCreateDirectory(manager, parentPath, true, logger);
                        }
                    }

                    PhoneCreateDirectory(manager, p, logger);
                }
                else
                {
                    PhoneCreateDirectory(manager, p, logger);
                }
            }
        }

        public static void PhoneDeleteDirectory(QcdmManager manager, string path, bool recursive, Logger logger)
        {
            try
            {
                if (!string.IsNullOrEmpty(path))
                {
                    var p = path;
                    if (p[p.Length - 1] == '/')
                    {
                        p = p.Substring(0, p.Length - 1);
                    }

                    if (recursive)
                    {
                        var ind = p.LastIndexOf('/');
                        if (ind >= 0)
                        {
                            var entries = PhoneOpenDirectory(manager, p, logger);
                            if (entries != null)
                            {
                                foreach (var entry in entries)
                                {
                                    if (entry.EntryType == DirectoryEntryType.Directory)
                                    {
                                        var dirPath = $"{p}/{entry.Name}";
                                        PhoneDeleteDirectory(manager, dirPath, true, logger);
                                        continue;
                                    }

                                    if (entry.EntryType == DirectoryEntryType.File ||
                                        entry.EntryType == DirectoryEntryType.ItemFile)
                                    {
                                        var filePath = $"{p}/{entry.Name}";
                                        PhoneDeleteFile(manager, filePath, logger);
                                    }
                                }
                            }
                        }

                        manager.Efs.DeleteDirectory(p);
                    }
                    else
                    {
                        manager.Efs.DeleteDirectory(p);
                    }
                }
            }
            catch (Exception e)
            {
                logger.LogError(string.Format(Strings.QcdmErrorOnDeleteDirectoryFormat, path, e.Message));
            }
        }

        public static DirectoryEntry[] PhoneOpenDirectory(QcdmManager manager, string path, Logger logger)
        {
            try
            {
                logger.LogInfo(string.Format(Strings.QcdmProcessingFormat, path));
                var p = path == "/" ? "." : path;
                using (var directory = manager.Efs.OpenDirectory(p))
                {
                    if (directory != null)
                    {
                        return directory.QueryEntries().ToArray();
                    }
                }
            }
            catch (Exception e)
            {
                logger.LogError(string.Format(Strings.QcdmErrorOnOpenDirectoryFormat, path, e.Message));
            }

            return null;
        }

        public static DirectoryEntry[] PhoneOpenDirectoryForList(QcdmManager manager, string path, Logger logger)
        {
            try
            {
                var p = string.IsNullOrEmpty(path) || path == "/" ? "." : path;
                using (var directory = manager.Efs.OpenDirectory(p))
                {
                    if (directory != null)
                    {
                        return directory.QueryEntries().ToArray();
                    }
                }
            }
            catch (Exception e)
            {
                logger.LogError(string.Format(Strings.QcdmErrorOnOpenDirectoryFormat, path, e.Message));
            }

            return null;
        }

        public static void PhoneDeleteFile(QcdmManager manager, string path, Logger logger)
        {
            try
            {
                manager.Efs.DeleteFile(path);
            }
            catch (Exception e)
            {
                logger.LogError(string.Format(Strings.QcdmErrorOnDeleteFileFormat, path, e.Message));
            }
        }

        public static void PhoneFixFileNames(QcdmManager manager, string path, Logger logger)
        {
            try
            {
                if (!string.IsNullOrEmpty(path))
                {
                    var entries = PhoneOpenDirectory(manager, path, logger);
                    if (entries != null)
                    {
                        foreach (var entry in entries)
                        {
                            if (entry.EntryType == DirectoryEntryType.Directory)
                            {
                                var path1 = $"{path}{entry.Name}/";
                                PhoneFixFileNames(manager, path1, logger);
                                continue;
                            }

                            if (entry.EntryType == DirectoryEntryType.File ||
                                entry.EntryType == DirectoryEntryType.ItemFile)
                            {
                                PhoneCheckAndFixFileName(manager, entry.Name, path, logger);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                logger.LogError(string.Format(Strings.QcdmErrorOnFixFileNamesFormat, path, e.Message));
            }
        }

        public static void PhoneListDirectory(QcdmManager manager, string path, bool recursive, string offset,
            Logger logger)
        {
            try
            {
                if (!string.IsNullOrEmpty(path))
                {
                    var p = path;
                    if (p[p.Length - 1] == '/')
                    {
                        p = p.Substring(0, p.Length - 1);
                    }

                    var entries = PhoneOpenDirectoryForList(manager, p, logger);
                    if (entries != null)
                    {
                        foreach (var entry in entries)
                        {
                            if (entry.EntryType == DirectoryEntryType.Directory)
                            {
                                logger.LogInfo($"{offset}[{entry.Name}]");
                                if (recursive)
                                {
                                    var of = $"{offset}  ";
                                    var dirPath = $"{p}/{entry.Name}";
                                    PhoneListDirectory(manager, dirPath, true, of, logger);
                                }

                                continue;
                            }

                            if (entry.EntryType == DirectoryEntryType.File ||
                                entry.EntryType == DirectoryEntryType.ItemFile)
                            {
                                var offsetName = $"{offset}{entry.Name}";
                                var len = 80 - offsetName.Length;
                                if (len <= 0)
                                {
                                    len = 1;
                                }

                                var fill = GetFillString(len);
                                logger.LogInfo($"{offsetName}{fill}{entry.Size} b\t{entry.Mode:X}\t{entry.EntryType}");
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                logger.LogError(string.Format(Strings.QcdmErrorOnDeleteDirectoryFormat, path, e.Message));
            }
        }

        public static void PhoneDownloadDirectory(QcdmManager manager, string efsPath, string computerPath,
            bool noExtraData, Logger logger)
        {
            try
            {
                var entries = PhoneOpenDirectory(manager, efsPath, logger);
                if (entries != null)
                {
                    Directory.CreateDirectory(computerPath);
                    foreach (var entry in entries)
                    {
                        if (entry.EntryType == DirectoryEntryType.Directory)
                        {
                            var path = $"{efsPath}{entry.Name}/";
                            var newComputerPath = $"{computerPath}{entry.Name}/";
                            PhoneDownloadDirectory(manager, path, newComputerPath, noExtraData, logger);
                            continue;
                        }

                        if (entry.EntryType == DirectoryEntryType.File ||
                            entry.EntryType == DirectoryEntryType.ItemFile)
                        {
                            PhoneDownloadFile(manager, entry, efsPath, computerPath, noExtraData, logger);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                logger.LogError(string.Format(Strings.QcdmErrorOnDownloadDirectoryFormat, efsPath, e.Message));
            }
        }

        public static void PhoneUploadDirectory(QcdmManager manager, string computerPath, string efsPath,
            bool createItemFilesAsDefault, Logger logger)
        {
            try
            {
                logger.LogInfo(string.Format(Strings.QcdmProcessingFormat, computerPath));
                var directories = Directory.EnumerateDirectories(computerPath);
                var files = Directory.EnumerateFiles(computerPath);
                PhoneCreateDirectory(manager, efsPath, true, logger);

                foreach (var directory in directories)
                {
                    var name = Path.GetFileName(directory);
                    var path = $"{efsPath}{name}/";
                    PhoneUploadDirectory(manager, directory, path, createItemFilesAsDefault, logger);
                }

                foreach (var file in files)
                {
                    if (file != null && !PathUtils.IsNvItemFileName(file))
                    {
                        var fileName = Path.GetFileName(file);
                        var path = PathUtils.RemoveExtraData(fileName, efsPath);
                        PhoneUploadFile(manager, file, path, createItemFilesAsDefault, logger);
                    }
                }
            }
            catch (Exception e)
            {
                logger.LogError(string.Format(Strings.QcdmErrorOnUploadDirectoryFormat, efsPath, e.Message));
            }
        }

        public static void PhoneReadFile(QcdmManager manager, string efsPath, string computerPath, Logger logger)
        {
            if (!string.IsNullOrEmpty(efsPath))
            {
                using (var input = PhoneOpenRead(manager, efsPath))
                {
                    using (var output = string.IsNullOrEmpty(computerPath)
                        ? StreamUtils.CreateLoggerStream(logger)
                        : LocalCreateWrite(computerPath))
                    {
                        StreamUtils.Copy(input, output);
                        output.Flush();
                        output.Close();
                    }

                    input.Close();
                }
            }
        }

        public static void PhoneWriteFile(QcdmManager manager, string computerPath, string efsPath, int permission,
            bool itemFile, Logger logger)
        {
            if (!string.IsNullOrEmpty(efsPath) && !string.IsNullOrEmpty(computerPath))
            {
                using (var input = LocalOpenRead(computerPath))
                {
                    using (var output = itemFile
                        ? PhoneItemCreateWrite(manager, efsPath, permission, logger)
                        : PhoneCreateWrite(manager, efsPath, permission, logger))
                    {
                        StreamUtils.Copy(input, output);
                        output.Flush();
                        output.Close();
                    }

                    input.Close();
                }
            }
        }

        private static void PhoneDownloadFile(QcdmManager manager, DirectoryEntry entry, string efsPath,
            string computerPath, bool noExtraData, Logger logger)
        {
            try
            {
                var entryName = entry.Name;
                var path1 = $"{efsPath}{entryName}";
                var path2 = PathUtils.BuildPath(computerPath, entryName, entry.Mode, entry.EntryType, noExtraData);
                PhoneReadFile(manager, path1, path2, logger);
            }
            catch (Exception e)
            {
                logger.LogError(string.Format(Strings.QcdmErrorOnDownloadFormat, efsPath, e.Message));
            }
        }

        private static void PhoneUploadFile(QcdmManager manager, string computerPath, string efsPath,
            bool createItemFilesAsDefault, Logger logger)
        {
            try
            {
                var fileName = Path.GetFileName(computerPath);
                if (fileName != null)
                {
                    var isItemFile = false;
                    var permission = 0777;
                    var info = PathUtils.ParsePath(fileName);
                    if (info == null)
                    {
                        isItemFile = createItemFilesAsDefault;
                        if (isItemFile)
                        {
                            var size = GetFileSize(computerPath);
                            if (size > 2048)
                            {
                                isItemFile = false;
                            }
                        }
                    }
                    else
                    {
                        permission = info.Permission;
                        isItemFile = info.IsItemFile;
                    }

                    PhoneWriteFile(manager, computerPath, efsPath, permission, isItemFile, logger);
                }
            }
            catch (Exception e)
            {
                logger.LogError(string.Format(Strings.QcdmErrorOnUploadFormat, efsPath, e.Message));
            }
        }

        private static long GetFileSize(string localPath)
        {
            using (var file = File.OpenRead(localPath))
            {
                var pos = file.Seek(0, SeekOrigin.End);
                file.Close();
                return pos;
            }
        }

        private static string GetFillString(int length)
        {
            var result = new StringBuilder();
            for (var i = 0; i < length; ++i)
            {
                result.Append(' ');
            }

            return result.ToString();
        }

        private static void PhoneCheckAndFixFileName(QcdmManager manager, string entryName, string efsPath,
            Logger logger)
        {
            var newEntryName = entryName.Replace("\n", "");
            newEntryName = newEntryName.Replace("\r", "");
            var efs = manager.Efs;
            if (newEntryName != entryName)
            {
                var oldPath = $"{efsPath}{entryName}";
                var newPath = $"{efsPath}{newEntryName}";
                if (efs.FileExists(newPath))
                {
                    efs.DeleteFile(oldPath);
                    efs.SyncNoWait(newPath, 1);
                }
                else
                {
                    efs.RenameFile(oldPath, newPath);
                    efs.SyncNoWait(newPath, 1);
                }

                //var stat1 = manager.Efs.FileStat(newPath);
                //var stat2 = manager.Efs.FileStat(oldPath);
                logger.LogInfo(string.Format(Strings.QcdmFixFileNameFormat, entryName, newEntryName, efsPath));
            }
        }

        private static void PhoneCreateDirectory(QcdmManager manager, string efsPath, Logger logger)
        {
            try
            {
                manager.Efs.CreateDirectory(efsPath, 0777);
            }
            catch (Exception e)
            {
                logger.LogError(string.Format(Strings.QcdmErrorOnCreateDirectoryFormat, efsPath, e.Message));
            }
        }
    }
}