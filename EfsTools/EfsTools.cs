using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using EfsTools.Items;
using EfsTools.Mbn;
using EfsTools.Qualcomm;
using EfsTools.Qualcomm.QcdmCommands.Base;
using EfsTools.Resourses;
using EfsTools.Utils;
using Microsoft.Extensions.Configuration;

namespace EfsTools
{
    internal class EfsTools
    {
        private readonly EfsToolsConfigurationSection _config;

        private readonly IConfigurationRoot _configurationRoot;
        private readonly Logger _logger;

        public EfsTools(Logger logger)
        {
            var builder = new ConfigurationBuilder();
            var module = Assembly.GetCallingAssembly().ManifestModule;
            var modulePath = $"{module.FullyQualifiedName}.config";
            _configurationRoot = builder.AddXmlFile(modulePath, false, false).Build();
            _config = new EfsToolsConfigurationSection(_configurationRoot);
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
                var systemTime = manager.SystemTime;

                _logger.LogInfo(
                    $"Imei: {imei}, " +
                    $"SerialNo: '{serialNo}', " +
                    $"MobileSoftwareId: '{buildId.MobileSoftwareId}', DiagVersion: {diagVersion}, CompilationDate: '{version.CompilationDate}', CompilationTime: '{version.CompilationTime}', ReleaseDate: '{version.ReleaseDate}', ReleaseTime: '{version.ReleaseTime}', " +
                    $"VersionDirectory: '{version.VersionDirectory}', MobileFirmwareRevision: {version.MobileFirmwareRevision}, MobileCaiRevision: {version.MobileCaiRevision}, MobileModel: {version.MobileModel}, " +
                    $"StationClassMask: {version.StationClassMask}, SlotCycleIndex: {version.SlotCycleIndex}, HwVersion: {version.HwVersionMajor}.{version.HwVersionMinor}, " +
                    $"MSM: 0x{buildId.Msm:X}, MobileModelId: {buildId.MobileModelId}, MobileModelName: {buildId.MobileModelName}, " +
                    $"Guid: '{guid}', SystemTime: '{systemTime}'");
                _logger.LogInfo(
                    $"GSM VocorerDspVersion: 0x{gsmVersion.VocorerDspVersion:X},  MdspVersionRom: 0x{gsmVersion.MdspVersionRom:X},  MdspVersionRam: 0x{gsmVersion.MdspVersionRam:X}");
                _logger.LogInfo($"Call state: 0x{state:X}");
            }
        }

        public void GetLog(string messageMask, string logMask, bool verbose)
        {
            var enabledMessageMasks = string.IsNullOrEmpty(messageMask)
                ? new MessageId[0]
                : messageMask.Split(',')
                    .Select(it => (MessageId) EnumUtils.ParseEnumInt(typeof(MessageId), it, _logger))
                    .ToArray();
            var enabledLogMasks = string.IsNullOrEmpty(logMask)
                ? new LogId[0]
                : logMask.Split(',').Select(it => (LogId) EnumUtils.ParseEnumInt(typeof(LogId), it, _logger))
                    .ToArray();

            using (var manager = OpenQcdmManager())
            {
                if (verbose)
                {
                    if (enabledMessageMasks.Length > 0)
                    {
                        _logger.LogInfo(Strings.QcdmLogSubcribingToMessagesFormat,
                            string.Join(", ", enabledMessageMasks));
                    }

                    if (enabledLogMasks.Length > 0)
                    {
                        _logger.LogInfo(Strings.QcdmLogSubcribingToLogsFormat,
                            string.Join(", ", enabledLogMasks));
                    }
                }

                var count1 = manager.DiagServ.DebugMessageDroppedCount;
                var count2 = manager.DiagServ.DebugMessageAllocationCount;
                var count5 = manager.DiagServ.LogDroppedCount;
                var count6 = manager.DiagServ.LogAllocationCount;

                manager.DisableEventReports();
                manager.DisableMessages();
                manager.DisableLogs();

                var affectedMessages = new HashSet<MessageId>(manager.SetMessageMask(enabledMessageMasks));
                var affectedLogs = new HashSet<LogId>(manager.SetLogMask(enabledLogMasks));

                if (verbose)
                {
                    if (enabledMessageMasks.Length > 0)
                    {
                        foreach (var enabledMessageMask in enabledMessageMasks)
                        {
                            if (!affectedMessages.Contains(enabledMessageMask))
                            {
                                _logger.LogWarning(Strings.QcdmLogSubcribingMessageNotSupportedErrorFormat,
                                    enabledMessageMask);
                            }
                        }

                        _logger.LogInfo(Strings.QcdmLogSubcribingToMessagesResultFormat,
                            string.Join(", ", affectedMessages));
                    }

                    if (enabledLogMasks.Length > 0)
                    {
                        foreach (var enabledLogMask in enabledLogMasks)
                        {
                            if (!affectedLogs.Contains(enabledLogMask))
                            {
                                _logger.LogWarning(Strings.QcdmLogSubcribingLogNotSupportedErrorFormat,
                                    enabledLogMask);
                            }
                        }

                        _logger.LogInfo(Strings.QcdmLogSubcribingToLogsResultFormat,
                            string.Join(", ", affectedLogs));
                    }
                }


                var cancellationTokenSource = new CancellationTokenSource();
                Console.CancelKeyPress += (sender, e) => { cancellationTokenSource.Cancel(); };

                manager.ProcessLogs(_logger, cancellationTokenSource.Token);
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
                    FileUtils.PhoneReadFile(manager, efsPath, computerPath, _logger);
                }
            }
        }

        public void EfsWriteFile(string computerPath, string efsPath, bool create, bool itemFile)
        {
            if (!string.IsNullOrEmpty(efsPath) && !string.IsNullOrEmpty(computerPath))
            {
                using (var manager = OpenQcdmManager())
                {
                    FileUtils.PhoneWriteFile(manager, computerPath, efsPath, 0777, itemFile, _logger);
                }
            }
        }

        public void EfsRenameFile(string efsPath, string newEfsPath)
        {
            if (!string.IsNullOrEmpty(efsPath) && !string.IsNullOrEmpty(newEfsPath))
            {
                using (var manager = OpenQcdmManager())
                {
                    var efs = manager.Efs;
                    efs.RenameFile(efsPath, newEfsPath);
                    efs.SyncNoWait(newEfsPath, 1);
                }
            }
        }

        public void EfsDownloadDirectory(string efsPath, string computerPath, bool noExtraData, bool processNvItems)
        {
            if (!string.IsNullOrEmpty(efsPath) && !string.IsNullOrEmpty(computerPath))
            {
                using (var manager = OpenQcdmManager())
                {
                    var path1 = PathUtils.FixUnixPath(efsPath);
                    var path2 = PathUtils.FixPath(computerPath);
                    FileUtils.PhoneDownloadDirectory(manager, path1, path2, noExtraData, _logger);
                    if (processNvItems)
                    {
                        NvItemUtils.PhoneDownloadNvItems(manager, path2, _logger);
                    }
                }
            }
        }

        public void EfsUploadDirectory(string computerPath, string efsPath, bool createItemFilesAsDefault,
            bool processNvItems)
        {
            if (!string.IsNullOrEmpty(efsPath) && !string.IsNullOrEmpty(computerPath))
            {
                var path1 = File.Exists(computerPath) ? computerPath : PathUtils.FixPath(computerPath);
                path1 = CheckAndFixPath(path1);
                if (!string.IsNullOrEmpty(path1))
                {
                    path1 = PathUtils.FixPath(path1);
                    using (var manager = OpenQcdmManager())
                    {
                        var path2 = PathUtils.FixUnixPath(efsPath);
                        FileUtils.PhoneUploadDirectory(manager, path1, path2, createItemFilesAsDefault, _logger);
                        if (processNvItems)
                        {
                            NvItemUtils.PhoneUploadNvItems(manager, path1, _logger);
                        }
                    }
                }
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

        public void GetModemConfig(string path, string inputDirectory, string itemNames, int subscription, bool verbose)
        {
            var inDirectory = inputDirectory;
            if (!string.IsNullOrEmpty(inDirectory))
            {
                inDirectory = CheckAndFixPath(inDirectory);
            }

            _logger.LogInfo(Strings.QcdmGeneratingModemConfig);

            if (string.IsNullOrEmpty(inputDirectory))
            {
                using (var manager = OpenQcdmManager())
                {
                    using (var output = File.CreateText(path))
                    {
                        var items = string.IsNullOrEmpty(itemNames)
                            ? NvItemUtils.PhoneLoadItems(manager, subscription, _logger, verbose)
                            : NvItemUtils.PhoneLoadItems(manager, subscription, _logger, verbose,
                                new HashSet<string>(itemNames.Split(',')));
                        ItemsJsonSerializer.SerializeItems(items, output);
                        output.Flush();
                        output.Close();
                    }
                }
            }
            else
            {
                using (var output = File.CreateText(path))
                {
                    var items = string.IsNullOrEmpty(itemNames)
                        ? NvItemUtils.LocalLoadItems(inDirectory, subscription, _logger, verbose)
                        : NvItemUtils.LocalLoadItems(inDirectory, subscription, _logger, verbose,
                            new HashSet<string>(itemNames.Split(',')));
                    ItemsJsonSerializer.SerializeItems(items, output);
                    output.Flush();
                    output.Close();
                }
            }
        }

        public void SetModemConfig(string path, string outputDirectory, int subscription)
        {
            _logger.LogInfo(Strings.QcdmApplyingModemConfig);
            if (string.IsNullOrEmpty(outputDirectory))
            {
                using (var manager = OpenQcdmManager())
                {
                    using (var input = new StreamReader(File.OpenRead(path), Encoding.UTF8, true))
                    {
                        var configItems = NvItemUtils.GetConfigs(input);
                        input.BaseStream.Seek(0, SeekOrigin.Begin);
                        var items = NvItemUtils.PhoneLoadItems(manager, subscription, _logger, false, configItems);
                        ItemsJsonSerializer.DeserializeItems(items, input);
                        NvItemUtils.PhoneSaveItems(manager, subscription, items, _logger);
                    }
                }
            }
            else
            {
                using (var input = new StreamReader(File.OpenRead(path), Encoding.UTF8, true))
                {
                    Directory.CreateDirectory(outputDirectory);
                    var configItems = NvItemUtils.GetConfigs(input);
                    input.BaseStream.Seek(0, SeekOrigin.Begin);
                    var items = NvItemUtils.LocalLoadItems(outputDirectory, subscription, _logger, false, configItems);
                    ItemsJsonSerializer.DeserializeItems(items, input);
                    NvItemUtils.LocalSaveItems(outputDirectory, subscription, items, _logger);
                }
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
            {
                using (var manager = OpenQcdmManager())
                {
                    var path = PathUtils.FixUnixPath(efsPath);
                    FileUtils.PhoneFixFileNames(manager, path, _logger);
                }
            }
        }

        public void ExtractMbn(string inputMbnFilePath, string outputComputerDirectoryPath, bool noExtraData)
        {
            _logger.LogInfo(Strings.QcdmExtractingMbnFileFormat, inputMbnFilePath);
            MbnExtractor.Extract(inputMbnFilePath, outputComputerDirectoryPath, noExtraData, _logger);
        }

        private string CheckAndFixPath(string path)
        {
            if (File.Exists(path) && Path.GetExtension(path) == ".mbn")
            {
                var b = Directory.Exists(path);
                var tmpPath = Path.Combine(Path.GetTempPath(), "EfsTools", Path.GetRandomFileName());
                Directory.CreateDirectory(tmpPath);
                ExtractMbn(path, tmpPath, true);
                return tmpPath;
            }

            return path;
        }

        private QcdmManager OpenQcdmManager()
        {
            var manager = new QcdmManager(_config.Port, _config.Baudrate, 5000);
            if (_config.Port != manager.PortName)
            {
                _logger.LogInfo(Strings.QcdmUseComPortFormat, manager.PortName);
            }

            manager.Open();
            manager.SendPassword(_config.Password);
            manager.SendSpc(_config.Spc);
            manager.DisableLogs();
            manager.DisableMessages();
            return manager;
        }
    }
}