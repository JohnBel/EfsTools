using System;
using CommandLine;
using CommandLine.Text;
using EfsTools.CommandLineOptions;
using EfsTools.Qualcomm.QcdmCommands;
using EfsTools.Resourses;

namespace EfsTools
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Logger logger = null;
            try
            {
                logger = new Logger();
                QcdmCommandResponseFactory.Logger = logger;
                SentenceBuilder.Factory = () => new CommandLineOptionsLocalization();
                var tools = new EfsTools(logger);
                using (var commandLineParser = new Parser(settings =>
                {
                    settings.CaseInsensitiveEnumValues = false;
                    settings.CaseSensitive = true;
                    settings.IgnoreUnknownArguments = false;
                    settings.EnableDashDash = true;
                    settings.HelpWriter = Console.Out;
                }))
                {
                    commandLineParser.ParseArguments<
                            GetTaggetInfoOptions,
                            GetEfsInfoOptions,
                            EfsReadFileOptions,
                            EfsWriteFileOptions,
                            EfsRenameFileOptions,
                            EfsDeleteFileOptions,
                            EfsFixFileNamesOptions,
                            EfsCreateDirectoryOptions,
                            EfsDeleteDirectoryOptions,
                            EfsListDirectoryOptions,
                            EfsDowloadDirectoryOptions,
                            EfsUploadDirectoryOptions,
                            GetModemConfigOptions,
                            SetModemConfigOptions,
                            ExtractMbnOptions,
                            GetLogsOptions
                        >(args)
                        .WithParsed<GetTaggetInfoOptions>(opts => tools.GetTargetInfo())
                        .WithParsed<GetEfsInfoOptions>(opts => tools.GetEfsInfo())
                        .WithParsed<EfsReadFileOptions>(opts =>
                            tools.EfsReadFile(opts.InEfsFilePath, opts.OutComputerFilePath))
                        .WithParsed<EfsWriteFileOptions>(opts => tools.EfsWriteFile(opts.InComputerFilePath,
                            opts.OutEfsFilePath, !opts.DontCreateEfsFile,
                            opts.IsItemFile))
                        .WithParsed<EfsRenameFileOptions>(opts =>
                            tools.EfsRenameFile(opts.EfsFilePath, opts.NewEfsFilePath))
                        .WithParsed<EfsDowloadDirectoryOptions>(opts =>
                            tools.EfsDownloadDirectory(opts.InEfsPath, opts.OutComputerPath, opts.NoExtraData,
                                opts.ProcessNvItems))
                        .WithParsed<EfsUploadDirectoryOptions>(opts => tools.EfsUploadDirectory(opts.InComputerPath,
                            opts.OutEfsPath, opts.CreateItemFilesAsDefault, opts.ProcessNvItems))
                        .WithParsed<EfsFixFileNamesOptions>(opts => tools.EfsFixFileNames(opts.EfsPath))
                        .WithParsed<EfsCreateDirectoryOptions>(opts =>
                            tools.EfsCreateDirectory(opts.Path, !opts.NoRecursive))
                        .WithParsed<EfsDeleteDirectoryOptions>(opts =>
                            tools.EfsDeleteDirectory(opts.Path, !opts.NoRecursive))
                        .WithParsed<EfsDeleteFileOptions>(opts => tools.EfsDeleteFile(opts.Path))
                        .WithParsed<EfsListDirectoryOptions>(opts => tools.EfsListDirectory(opts.Path, opts.Recursive))
                        .WithParsed<GetModemConfigOptions>(opts =>
                            tools.GetModemConfig(opts.OutComputerFilePath, opts.InComputerFilePath, opts.ItemNames, opts.SubscriptionIndex))
                        .WithParsed<SetModemConfigOptions>(opts =>
                            tools.SetModemConfig(opts.InComputerFilePath, opts.OutComputerFilePath, opts.SubscriptionIndex))
                        .WithParsed<ExtractMbnOptions>(opts =>
                            tools.ExtractMbn(opts.InputMbnFilePath, opts.OutputComputerDirectoryPath, opts.NoExtraData))
                        .WithParsed<GetLogsOptions>(opts => 
                            tools.GetLog(opts.MessageMask, opts.LogMask, opts.Verbose))
                        .WithNotParsed(errors => { });
                }
            }
            catch (Exception ex)
            {
                logger?.LogError(Strings.CriticalErrorFormat, ex.Message);
            }
        }
    }
}