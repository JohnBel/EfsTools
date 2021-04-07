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
                    var cmd = commandLineParser.ParseArguments(args,
                        typeof(GetTargetInfoOptions),
                        typeof(GetEfsInfoOptions),
                        typeof(EfsReadFileOptions),
                        typeof(EfsWriteFileOptions),
                        typeof(EfsRenameFileOptions),
                        typeof(EfsDeleteFileOptions),
                        typeof(EfsFixFileNamesOptions),
                        typeof(EfsCreateDirectoryOptions),
                        typeof(EfsDeleteDirectoryOptions),
                        typeof(EfsListDirectoryOptions),
                        typeof(EfsDownloadDirectoryOptions),
                        typeof(EfsUploadDirectoryOptions),
                        typeof(GetModemConfigOptions),
                        typeof(SetModemConfigOptions),
                        typeof(ExtractMbnOptions),
                        typeof(StartWebDavServerOptions),
                        typeof(GetLogsOptions)
                    );

                    cmd.WithParsed<GetTargetInfoOptions>(opts => tools.GetTargetInfo());
                    cmd.WithParsed<GetEfsInfoOptions>(opts => tools.GetEfsInfo());
                    cmd.WithParsed<EfsReadFileOptions>(opts =>
                        tools.EfsReadFile(opts.InEfsFilePath, opts.OutComputerFilePath));
                    cmd.WithParsed<EfsWriteFileOptions>(opts => tools.EfsWriteFile(opts.InComputerFilePath,
                        opts.OutEfsFilePath, !opts.DontCreateEfsFile, opts.IsItemFile));
                    cmd.WithParsed<EfsRenameFileOptions>(opts =>
                        tools.EfsRenameFile(opts.EfsFilePath, opts.NewEfsFilePath));
                    cmd.WithParsed<EfsDownloadDirectoryOptions>(opts =>
                        tools.EfsDownloadDirectory(opts.InEfsPath, opts.OutComputerPath, opts.NoExtraData,
                            opts.ProcessNvItems));
                    cmd.WithParsed<EfsUploadDirectoryOptions>(opts => tools.EfsUploadDirectory(opts.InComputerPath,
                        opts.OutEfsPath, opts.CreateItemFilesAsDefault, opts.ProcessNvItems));
                    cmd.WithParsed<EfsFixFileNamesOptions>(opts => tools.EfsFixFileNames(opts.EfsPath));
                    cmd.WithParsed<EfsCreateDirectoryOptions>(opts =>
                        tools.EfsCreateDirectory(opts.Path, !opts.NoRecursive));
                    cmd.WithParsed<EfsDeleteDirectoryOptions>(opts =>
                        tools.EfsDeleteDirectory(opts.Path, !opts.NoRecursive));
                    cmd.WithParsed<EfsDeleteFileOptions>(opts => tools.EfsDeleteFile(opts.Path));
                    cmd.WithParsed<EfsListDirectoryOptions>(opts => tools.EfsListDirectory(opts.Path, opts.Recursive));
                    cmd.WithParsed<GetModemConfigOptions>(opts =>
                        tools.GetModemConfig(opts.OutComputerFilePath, opts.InComputerFilePath, opts.ItemNames,
                            opts.SubscriptionIndex, opts.Verbose));
                    cmd.WithParsed<SetModemConfigOptions>(opts =>
                        tools.SetModemConfig(opts.InComputerFilePath, opts.OutComputerFilePath,
                            opts.SubscriptionIndex, opts.Verbose));
                    cmd.WithParsed<ExtractMbnOptions>(opts =>
                        tools.ExtractMbn(opts.InputMbnFilePath, opts.OutputComputerDirectoryPath, opts.NoExtraData));
                    cmd.WithParsed<GetLogsOptions>(opts =>
                        tools.GetLog(opts.MessageMask, opts.LogMask, opts.Verbose));
                    cmd.WithParsed<StartWebDavServerOptions>(opts =>
                        tools.StartWebDavServer(opts.Port, opts.LogLevel, opts.ReadOnly != 0));
                    cmd.WithNotParsed(errors => { });
                }
            }
            catch (Exception ex)
            {
                logger?.LogError(Strings.CriticalErrorFormat, ex.Message);
            }
        }
    }
}