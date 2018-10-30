using System.Configuration;
using System.IO;
using EfsTools.Items;
using EfsTools.Qualcomm;
using EfsTools.Resourses;
using EfsTools.Utils;

namespace EfsTools
{
    internal class EfsTools
    {
        private readonly EfsToolsConfigurationSection _config;
        private readonly Logger _logger;

        public EfsTools(Logger logger)
        {
            _config = (EfsToolsConfigurationSection) ConfigurationManager.GetSection("efstool");
            _logger = logger;
        }

        public void GetTargetInfo()
        {
            using (var manager = OpenQcdmManager())
            {
                var diagVersion = manager.DiagVersion;
                var version = manager.Version;
                var buildId = manager.BuildId;
                var guid = manager.Guid;
                var gsmVersion = manager.Gsm.Version;
                var state = manager.CallManager.CallState;
                var serialNo = manager.Nv.ReadString(2824).TrimEnd('\0');
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
                using (var manager = OpenQcdmManager())
                {
                    FileUtils.PhoneReadFile(manager, efsPath, computerPath, _logger);
                }
        }

        public void EfsWriteFile(string computerPath, string efsPath, bool create, bool itemFile)
        {
            if (!string.IsNullOrEmpty(efsPath) && !string.IsNullOrEmpty(computerPath))
                using (var manager = OpenQcdmManager())
                {
                    FileUtils.PhoneWriteFile(manager, computerPath, efsPath, 0777, itemFile, _logger);
                }
        }

        public void EfsRenameFile(string efsPath, string newEfsPath)
        {
            if (!string.IsNullOrEmpty(efsPath) && !string.IsNullOrEmpty(newEfsPath))
                using (var manager = OpenQcdmManager())
                {
                    var efs = manager.Efs;
                    efs.RenameFile(efsPath, newEfsPath);
                    efs.SyncNoWait(newEfsPath, 1);
                }
        }

        public void EfsDownloadDirectory(string efsPath, string computerPath, bool noExtraData, bool processNvItems)
        {
            if (!string.IsNullOrEmpty(efsPath) && !string.IsNullOrEmpty(computerPath))
                using (var manager = OpenQcdmManager())
                {
                    var path1 = PathUtils.FixUnixPath(efsPath);
                    var path2 = PathUtils.FixPath(computerPath);
                    FileUtils.PhoneDownloadDirectory(manager, path1, path2, noExtraData, _logger);
                    if (processNvItems) NvItemUtils.PhoneDownloadNvItems(manager, path2, _logger);
                }
        }

        public void EfsUploadDirectory(string computerPath, string efsPath, bool createItemFilesAsDefault,
            bool processNvItems)
        {
            if (!string.IsNullOrEmpty(efsPath) && !string.IsNullOrEmpty(computerPath))
                using (var manager = OpenQcdmManager())
                {
                    var path1 = PathUtils.FixPath(computerPath);
                    var path2 = PathUtils.FixUnixPath(efsPath);
                    FileUtils.PhoneUploadDirectory(manager, path1, path2, createItemFilesAsDefault, _logger);
                    if (processNvItems) NvItemUtils.PhoneUploadNvItems(manager, path1, _logger);
                }
        }

        public void EfsCreateDirectory(string path, bool recursive)
        {
            using (var manager = OpenQcdmManager())
            {
                FileUtils.PhoneCreateDirectory(manager, path, recursive, _logger);
            }
        }

        public void EfsDeleteDirectory(string path, bool recursive)
        {
            using (var manager = OpenQcdmManager())
            {
                FileUtils.PhoneDeleteDirectory(manager, path, recursive, _logger);
            }
        }

        public void EfsListDirectory(string path, bool recursive)
        {
            using (var manager = OpenQcdmManager())
            {
                _logger.LogInfo(string.Format(Strings.QcdmListOfDirectoryFormat, path));
                FileUtils.PhoneListDirectory(manager, path, recursive, string.Empty, _logger);
            }
        }

        public void GetModemConfig(string path, string inputDirectory)
        {
            _logger.LogInfo(Strings.QcdmGeneratingModemConfig);

            if (string.IsNullOrEmpty(inputDirectory))
                using (var manager = OpenQcdmManager())
                {
                    using (var output = File.CreateText(path))
                    {
                        var items = NvItemUtils.PhoneLoadItems(manager);
                        ItemsJsonSerializer.SerializeItems(items, output);
                        output.Flush();
                        output.Close();
                    }
                }
            else
                using (var output = File.CreateText(path))
                {
                    var items = NvItemUtils.LocalLoadItems(inputDirectory);
                    ItemsJsonSerializer.SerializeItems(items, output);
                    output.Flush();
                    output.Close();
                }
        }

        public void SetModemConfig(string path, string outputDirectory)
        {
            _logger.LogInfo(Strings.QcdmApplyingModemConfig);
            if (string.IsNullOrEmpty(outputDirectory))
                using (var manager = OpenQcdmManager())
                {
                    using (var input = File.OpenText(path))
                    {
                        var configItems = NvItemUtils.GetConfigs(input);
                        input.BaseStream.Seek(0, SeekOrigin.Begin);
                        var items = NvItemUtils.PhoneLoadItems(manager, configItems);
                        ItemsJsonSerializer.DeserializeItems(items, input);
                        NvItemUtils.PhoneSaveItems(manager, items, _logger);
                    }
                }
            else
                using (var input = File.OpenText(path))
                {
                    Directory.CreateDirectory(outputDirectory);
                    var configItems = NvItemUtils.GetConfigs(input);
                    input.BaseStream.Seek(0, SeekOrigin.Begin);
                    var items = NvItemUtils.LocalLoadItems(outputDirectory, configItems);
                    ItemsJsonSerializer.DeserializeItems(items, input);
                    NvItemUtils.LocalSaveItems(outputDirectory, items, _logger);
                }
        }

        public void EfsDeleteFile(string path)
        {
            using (var manager = OpenQcdmManager())
            {
                FileUtils.PhoneDeleteFile(manager, path, _logger);
            }
        }

        public void EfsFixFileNames(string efsPath)
        {
            if (!string.IsNullOrEmpty(efsPath))
                using (var manager = OpenQcdmManager())
                {
                    var path = PathUtils.FixUnixPath(efsPath);
                    FileUtils.PhoneFixFileNames(manager, path, _logger);
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
    }
}