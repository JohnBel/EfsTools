using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using EfsTools.Qualcomm;
using EfsTools.Qualcomm.QcdmCommands.Requests.Efs;
using EfsTools.Qualcomm.QcdmCommands.Responses.Efs;
using EfsTools.Qualcomm.QcdmManagers;
using EfsTools.Resourses;

namespace EfsTools
{
    internal class EfsTools
    {
        public EfsTools(Logger logger)
        {
            _config = (EfsToolsConfigurationSection) ConfigurationManager.GetSection("efstool");
            _logger = logger;
        }

        public void GetTaggetInfo()
        {
            using (var manager = OpenQcdmManager())
            {
                var diagVersion = manager.DiagVersion;
                var version = manager.Version;
                var buildId = manager.BuildId;
                var guid = manager.Guid;
                var gsmVersion = manager.Gsm.Version;
                var state = manager.CallManager.CallState;
                var serialNo = manager.NvReadString(2824).TrimEnd('\0');
                var imei = manager.Imei;
                
                _logger.LogInfo(
                    $"Imei: {imei}, " +
                    $"SerialNo: '{serialNo}', " +
                    $"MobileSoftwareId: '{buildId.MobileSoftwareId}', DiagVersion: {diagVersion}, CompilationDate: '{version.CompilationDate}', CompilationTime: '{version.CompilationTime}', ReleaseDate: '{version.ReleaseDate}', ReleaseTime: '{version.ReleaseTime}', " +
                    $"VersionDirectory: '{version.VersionDirectory}', MobileFirmwareRevision: {version.MobileFirmwareRevision}, MobileCaiRevision: {version.MobileCaiRevision}, MobileModel: {version.MobileModel}, " +
                    $"StationClassMask: {version.StationClassMask}, SlotCycleIndex: {version.SlotCycleIndex}, HwVersion: {version.HwVersionMajor}.{version.HwVersionMinor}, " +
                    $"MSM: 0x{buildId.Msm:X}, MobileModelId: {buildId.MobileModelId}, MobileModelName: {buildId.MobileModelName}, " +
                    $"Guid: {guid}");
                _logger.LogInfo(
                    $"GSM VocorerDspVersion: 0x{gsmVersion.VocorerDspVersion:X},  MdspVersionRom: 0x{gsmVersion.MdspVersionRom:X},  MdspVersionRam: 0x{gsmVersion.MdspVersionRam:X}");
                _logger.LogInfo($"Call state: 0x{state:X}");
            }
        }

        public void GetLog()
        {
            using (var manager = OpenQcdmManager())
            {
                //manager.SetLogMask(0xFF);
                var log = manager.QueryLog();
                _logger.LogInfo($"Log: {log}");
            }
        }

        public void GetTime()
        {
            using (var manager = OpenQcdmManager())
            {
                var time = manager.SystemTime;
                _logger.LogInfo($"Time: {time}");
            }
        }

        public void GetEfsInfo()
        {
            using (var manager = OpenQcdmManager())
            {
                var helloInfo = manager.Efs.HelloInfo;
                var efsInfo = manager.Efs.EfsInfo;
                _logger.LogInfo(
                    $"Version: {helloInfo.Version}, MaxDirectories: {efsInfo.MaxDirectories}, MapPathnameLength: {efsInfo.MapPathnameLength}, " +
                    $"MaxFileSize: {efsInfo.MaxFileSize}, MaxFilenameLength: {efsInfo.MaxFilenameLength}, MaxMounts: {efsInfo.MaxMounts}, " +
                    $"MaxSymlinkDepth: {efsInfo.MaxSymlinkDepth}");
            }
        }

        public void EfsReadFile(string efsPath, string computerPath)
        {
            if (!string.IsNullOrEmpty(efsPath))
            {
                using (var manager = OpenQcdmManager())
                {
                    EfsReadFile(efsPath, computerPath, manager);
                }
            }
        }

        private void EfsReadFile(string efsPath, string computerPath, QcdmManager manager)
        {
            using (var inFile = manager.Efs.OpenFile(efsPath, EfsFileFlag.Readonly, 0))
            {
                var buf = new byte[1024];
                if (string.IsNullOrEmpty(computerPath))
                {
                    using (var reader = new StreamReader(inFile))
                    {
                        var text = reader.ReadToEnd();
                        _logger.LogInfo(text);
                    }
                }
                else
                {
                    using (Stream outFile = File.Create(computerPath))
                    {
                        while (inFile.Position < inFile.Length)
                        {
                            var read = inFile.Read(buf, 0, buf.Length);
                            outFile.Write(buf, 0, read);
                        }

                        outFile.Flush();
                        outFile.Close();
                    }
                }
                inFile.Close();
            }
        }

        public void EfsWriteFile(string computerPath, string efsPath, bool create, bool itemFile)
        {
            if (!string.IsNullOrEmpty(efsPath) && !string.IsNullOrEmpty(computerPath))
            {
                using (var manager = OpenQcdmManager())
                {
                    EfsWriteFile(computerPath, efsPath, create, itemFile, 0777, manager);
                }
            }
        }

        private static void EfsWriteFile(string computerPath, string efsPath, bool create, bool itemFile, int permission, QcdmManager manager)
        {
            if (itemFile)
            {
                var flags = EfsFileFlag.Writeonly | EfsFileFlag.Truncate | EfsFileFlag.Create | EfsFileFlag.ItemFile;
                var data = ReadComputerFile(computerPath);
                manager.Efs.PutItemFile(efsPath, flags, permission, data);
                return;
            }

            bool doSecondTry = true;
            try
            {
                var fileExist = manager.Efs.FileExist(efsPath);
                if (!fileExist && !create)
                {
                    doSecondTry = false;
                    throw new QcdmManagerException(Strings.QcdmEfsErrorsDirEntNotFound);
                }
                EfsWriteFile(computerPath, efsPath, permission, EfsFileFlag.Writeonly | EfsFileFlag.Truncate, manager);
            }
            catch (Exception e)
            {
                if (doSecondTry)
                {
                    EfsWriteFile(computerPath, efsPath, permission, EfsFileFlag.Writeonly | EfsFileFlag.Create,
                        manager);
                }
                else
                {
                    throw e;
                }
            }
        }

        private static void EfsWriteFile(string computerPath, string efsPath, int permission, EfsFileFlag flags, QcdmManager manager)
        {
            using (var outFile = manager.Efs.OpenFile(efsPath, flags, permission))
            {
                var buf = new byte[1024];

                using (var inFile = File.Open(computerPath, FileMode.Open, FileAccess.Read))
                {
                    while (inFile.Position < inFile.Length)
                    {
                        var read = inFile.Read(buf, 0, buf.Length);
                        outFile.Write(buf, 0, read);
                    }

                    inFile.Close();
                }

                outFile.Flush();
                outFile.Close();
            }
        }

        private static byte[] ReadComputerFile(string path)
        {
            using (var inFile = File.Open(path, FileMode.Open, FileAccess.Read))
            {
                var buf = new byte[inFile.Length];
                inFile.Read(buf, 0, buf.Length);
                inFile.Close();
                return buf;
            }
        }

        public void EfsRenameFile(string efsPath, string newEfsPath)
        {
            if (!string.IsNullOrEmpty(efsPath) && !string.IsNullOrEmpty(newEfsPath))
            {
                using (var manager = OpenQcdmManager())
                {
                    manager.Efs.RenameFile(efsPath, newEfsPath);
                    manager.Efs.SyncNoWait(newEfsPath, 1);
                }
            }
        }

        public void EfsDownloadDirectory(string efsPath, string computerPath, bool noExtraData)
        {
            if (!string.IsNullOrEmpty(efsPath) && !string.IsNullOrEmpty(computerPath))
            {
                using (var manager = OpenQcdmManager())
                {
                    var path1 = (efsPath.LastOrDefault() == '/') ? efsPath : $"{efsPath}/";
                    var path2 = (computerPath.LastOrDefault() == '/' || computerPath.LastOrDefault() == '\\') ? computerPath : $"{computerPath}/";
                    EfsDownloadDirectory(path1, path2, noExtraData, manager);
                }
            }
        }

        public void EfsUploadDirectory(string computerPath, string efsPath)
        {
            if (!string.IsNullOrEmpty(efsPath) && !string.IsNullOrEmpty(computerPath))
            {
                using (var manager = OpenQcdmManager())
                {
                    var path1 = (computerPath.LastOrDefault() == '/' || computerPath.LastOrDefault() == '\\') ? computerPath : $"{computerPath}/";
                    var path2 = (efsPath.LastOrDefault() == '/') ? efsPath : $"{efsPath}/";
                    EfsUploadDirectory(path1, path2, manager);
                }
            }
        }

        public void EfsCreateDirectory(string path, bool recursive)
        {
            using (var manager = OpenQcdmManager())
            {
                EfsCreateDirectory(path, recursive, manager);
            }
        }

        private void EfsCreateDirectory(string path, bool recursive, QcdmManager manager)
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
                            EfsCreateDirectory(parentPath, recursive, manager);
                        }
                    }

                    EfsCreateDirectory(p, manager);
                }
                else
                {
                    EfsCreateDirectory(p, manager);
                }
            }
        }

        public void EfsDeleteDirectory(string path, bool recursive)
        {
            using (var manager = OpenQcdmManager())
            {
                EfsDeleteDirectory(path, recursive, manager);
            }
        }

        private void EfsDeleteDirectory(string path, bool recursive, QcdmManager manager)
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
                        if (ind > 0)
                        {
                            var entries = OpenDirectory(p, manager);
                            if (entries != null)
                            {
                                foreach (var entry in entries)
                                {
                                    if (entry.EntryType == DirectoryEntryType.Directory)
                                    {
                                        var dirPath = $"{p}/{entry.Name}";
                                        EfsDeleteDirectory(dirPath, recursive, manager);
                                        continue;
                                    }

                                    if (entry.EntryType == DirectoryEntryType.File ||
                                        entry.EntryType == DirectoryEntryType.ItemFile)
                                    {
                                        var filePath = $"{p}/{entry.Name}";
                                        EfsDeleteFile(filePath, manager);
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
                _logger.LogError(string.Format(Strings.QcdmErrorOnDeleteDirectoryFormat, path, e.Message));
            }
        }

        public void EfsListDirectory(string path, bool recursive)
        {
            using (var manager = OpenQcdmManager())
            {
                _logger.LogInfo(string.Format(Strings.QcdmListOfDirectoryFormat, path));
                EfsListDirectory(path, recursive, string.Empty, manager);
            }
        }

        private void EfsListDirectory(string path, bool recursive, string offset, QcdmManager manager)
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

                    var entries = OpenDirectoryForList(p, manager);
                    if (entries != null)
                    {
                        foreach (var entry in entries)
                        {
                            if (entry.EntryType == DirectoryEntryType.Directory)
                            {
                                _logger.LogInfo($"{offset}[{entry.Name}]");
                                if (recursive)
                                {
                                    var of = $"{offset}  ";
                                    var dirPath = $"{p}/{entry.Name}";
                                    EfsListDirectory(dirPath, recursive, of, manager);
                                }

                                continue;
                            }

                            if (entry.EntryType == DirectoryEntryType.File ||
                                entry.EntryType == DirectoryEntryType.ItemFile)
                            {
                                var offsetedName = $"{offset}{entry.Name}";
                                var len = 80 - offsetedName.Length;
                                if (len <= 0)
                                {
                                    len = 1;
                                }
                                var fill = GetFillString(len);
                                _logger.LogInfo($"{offsetedName}{fill}{entry.Size} b\t{entry.Mode:X}\t{entry.EntryType}");
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                _logger.LogError(string.Format(Strings.QcdmErrorOnDeleteDirectoryFormat, path, e.Message));
            }
        }

        private static string GetFillString(int length)
        {
            var result = new StringBuilder();
            for (int i = 0; i < length; ++i)
            {
                result.Append(' ');
            }
            return result.ToString();
        }

        public void EfsDeleteFile(string path)
        {
            using (var manager = OpenQcdmManager())
            {
                EfsDeleteFile(path, manager);
            }
        }

        private void EfsDeleteFile(string path, QcdmManager manager)
        {
            try
            {
                manager.Efs.DeleteFile(path);
            }
            catch (Exception e)
            {
                _logger.LogError(string.Format(Strings.QcdmErrorOnDeleteFileFormat, path, e.Message));
            }
        }

        private void EfsDownloadDirectory(string efsPath, string computerPath, bool noExtraData, QcdmManager manager)
        {
            try
            {
                var entries = OpenDirectory(efsPath, manager);
                if (entries != null)
                {
                    Directory.CreateDirectory(computerPath);
                    foreach (var entry in entries)
                    {
                        if (entry.EntryType == DirectoryEntryType.Directory)
                        {
                            var path = $"{efsPath}{entry.Name}/";
                            var newComputerPath = $"{computerPath}{entry.Name}/";
                            EfsDownloadDirectory(path, newComputerPath, noExtraData, manager);
                            continue;
                        }

                        if (entry.EntryType == DirectoryEntryType.File ||
                            entry.EntryType == DirectoryEntryType.ItemFile)
                        {
                            DownloadFile(entry, efsPath, computerPath, noExtraData, manager);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                _logger.LogError(string.Format(Strings.QcdmErrorOnDownloadDirectoryFormat, efsPath, e.Message));
            }
        }

        private void EfsUploadDirectory(string computerPath, string efsPath, QcdmManager manager)
        {
            try
            {
                _logger.LogInfo(string.Format(Strings.QcdmProcessingFormat, computerPath));
                var directories = Directory.EnumerateDirectories(computerPath);
                var files = Directory.EnumerateFiles(computerPath);
                EfsCreateDirectory(efsPath, true, manager);

                foreach (var directory in directories)
                {
                    var name = Path.GetFileName(directory);
                    var path = $"{efsPath}{name}/";
                    EfsUploadDirectory(directory, path, manager);
                }

                foreach (var file in files)
                {
                    if (file != null)
                    {
                        var fileName = Path.GetFileName(file);
                        var ind = fileName.IndexOf("__", StringComparison.Ordinal);
                        var path = ind > 0 ? $"{efsPath}{fileName.Substring(0, ind)}" : $"{efsPath}{fileName}";
                        UploadFile(file, path, manager);
                    }
                }
            }
            catch (Exception e)
            {
                _logger.LogError(string.Format(Strings.QcdmErrorOnUploadDirectoryFormat, efsPath, e.Message));
            }
        }

        private void DownloadFile(DirectoryEntry entry, string efsPath, string computerPath, bool noExtraData, QcdmManager manager)
        {
            try
            {
                var entryName = entry.Name;
                var path1 = $"{efsPath}{entryName}";
                var path2 = noExtraData ? $"{computerPath}{entryName}" :
                    $"{computerPath}{entryName}__{entry.Mode:X}_{(int)(entry.EntryType):X}";
                EfsReadFile(path1, path2, manager);
            }
            catch (Exception e)
            {
                _logger.LogError(string.Format(Strings.QcdmErrorOnDownloadFormat, efsPath, e.Message));
            }
        }

        private void UploadFile(string computerPath, string efsPath, QcdmManager manager)
        {
            try
            {
                var fileName = Path.GetFileName(computerPath);
                if (fileName != null)
                {
                    bool isItemFile = false;
                    int mode = 0777;
                    var match = _fileNameParser.Match(fileName);
                    if (match.Success)
                    {
                        var entryTypeStr = match.Groups["entryType"].Value;
                        var modeStr = match.Groups["mode"].Value;
                        mode = int.Parse(modeStr, NumberStyles.HexNumber);
                        var entryType = (DirectoryEntryType)int.Parse(entryTypeStr, NumberStyles.HexNumber);
                        isItemFile = (entryType == DirectoryEntryType.ItemFile);
                    }
                    EfsWriteFile(computerPath, efsPath, true, isItemFile, mode, manager);
                }
            }
            catch (Exception e)
            {
                _logger.LogError(string.Format(Strings.QcdmErrorOnUploadFormat, efsPath, e.Message));
            }
        }

        private readonly Regex _fileNameParser = new Regex("^.*__(?<mode>[0-9, A-F]+)_(?<entryType>[0-9, A-F]+)", 
            RegexOptions.Compiled | RegexOptions.Singleline | RegexOptions.CultureInvariant);

        void EfsCreateDirectory(string efsPath, QcdmManager manager)
        {
            try
            {
                manager.Efs.CreateDirectory(efsPath, 0777);
            }
            catch (Exception e)
            {
                _logger.LogError(string.Format(Strings.QcdmErrorOnCreateDirectoryFormat, efsPath, e.Message));
            }
        }

        public void EfsFixFileNames(string efsPath)
        {
            if (!string.IsNullOrEmpty(efsPath))
            {
                using (var manager = OpenQcdmManager())
                {
                    var path = (efsPath.LastOrDefault() == '/') ? efsPath : $"{efsPath}/";
                    EfsFixFileNames(path, manager);
                }
            }
        }

        private DirectoryEntry[] OpenDirectory(string path, QcdmManager manager)
        {
            try
            {
                _logger.LogInfo(string.Format(Strings.QcdmProcessingFormat, path));
                var p = (path == "/") ? "." : path;
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
                _logger.LogError(string.Format(Strings.QcdmErrorOnOpenDirectoryFormat, path, e.Message));
            }
            return null;
        }

        private DirectoryEntry[] OpenDirectoryForList(string path, QcdmManager manager)
        {
            try
            {
                var p = (string.IsNullOrEmpty(path) || path == "/") ? "." : path;
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
                _logger.LogError(string.Format(Strings.QcdmErrorOnOpenDirectoryFormat, path, e.Message));
            }
            return null;
        }

        private void EfsFixFileNames(string efsPath, QcdmManager manager)
        {
            try
            {
                if (!string.IsNullOrEmpty(efsPath))
                {
                    var entries = OpenDirectory(efsPath, manager);
                    if (entries != null)
                    {
                        foreach (var entry in entries)
                        {
                            if (entry.EntryType == DirectoryEntryType.Directory)
                            {
                                var path = $"{efsPath}{entry.Name}/";
                                EfsFixFileNames(path, manager);
                                continue;
                            }

                            if (entry.EntryType == DirectoryEntryType.File ||
                                entry.EntryType == DirectoryEntryType.ItemFile)
                            {
                                CheckAndFixFileName(entry.Name, efsPath, manager);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                _logger.LogError(string.Format(Strings.QcdmErrorOnFixFileNamesFormat, efsPath, e.Message));
            }
        }

        private void CheckAndFixFileName(string entryName, string efsPath, QcdmManager manager)
        {
            var newEntryName = entryName.Replace("\n", "");
            newEntryName = newEntryName.Replace("\r", "");
            if (newEntryName != entryName)
            {
                var oldPath = $"{efsPath}{entryName}";
                var newPath = $"{efsPath}{newEntryName}";
                manager.Efs.RenameFile(oldPath, newPath);
                manager.Efs.SyncNoWait(newPath, 1);
                var stat1 = manager.Efs.FileStat(newPath);
                var stat2 = manager.Efs.FileStat(oldPath);
                _logger.LogInfo(string.Format(Strings.QcdmFixFileNameFormat, entryName, newEntryName, efsPath));
            }
        }

        private QcdmManager OpenQcdmManager()
        {
            var manager = new QcdmManager(_config.Port, _config.Baudrate, 5000);
            manager.Open();
            manager.SendPassword(_config.Password);
            manager.SendSpc(_config.Spc);
            return manager;
        }

        private readonly EfsToolsConfigurationSection _config;
        private readonly Logger _logger;
    }
}