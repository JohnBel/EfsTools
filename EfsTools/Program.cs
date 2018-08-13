using System;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading;
using CommandLine;
using CommandLine.Text;
using EfsTools.CommandLineOptions;
using EfsTools.CommandLineOptions.Helper;
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
                //CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
                //CultureInfo.CurrentUICulture = CultureInfo.CurrentCulture;
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

                    commandLineParser.ParseArguments<GetTaggetInfoOptions,
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
                            EfsUploadDirectoryOptions
                        > (args)
                        .WithParsed<GetTaggetInfoOptions>(opts => tools.GetTaggetInfo())
                        .WithParsed<GetEfsInfoOptions>(opts => tools.GetEfsInfo())
                        .WithParsed<EfsReadFileOptions>(opts => tools.EfsReadFile(opts.InEfsFilePath, opts.OutComputerFilePath))
                        .WithParsed<EfsWriteFileOptions>(opts => tools.EfsWriteFile(opts.InComputerFilePath, opts.OutEfsFilePath, !opts.DontCreateEfsFile,
                            opts.IsItemFile))
                        .WithParsed<EfsRenameFileOptions>(opts => tools.EfsRenameFile(opts.EfsFilePath, opts.NewEfsFilePath))
                        .WithParsed<EfsDowloadDirectoryOptions>(opts => tools.EfsDownloadDirectory(opts.InEfsPath, opts.OutComputerPath, opts.NoExtraData))
                        .WithParsed<EfsUploadDirectoryOptions>(opts => tools.EfsUploadDirectory(opts.InComputerPath, opts.OutEfsPath, opts.CreateItemFilesAsDefault))
                        .WithParsed<EfsFixFileNamesOptions>(opts => tools.EfsFixFileNames(opts.EfsPath))
                        .WithParsed<GetLogsOptions>(opts => tools.GetLog())
                        .WithParsed<EfsCreateDirectoryOptions>(opts => tools.EfsCreateDirectory(opts.Path, !opts.NoRecursive))
                        .WithParsed<EfsDeleteDirectoryOptions>(opts => tools.EfsDeleteDirectory(opts.Path, !opts.NoRecursive))
                        .WithParsed<EfsDeleteFileOptions>(opts => tools.EfsDeleteFile(opts.Path))
                        .WithParsed<EfsListDirectoryOptions>(opts => tools.EfsListDirectory(opts.Path, opts.Recursive))
                        .WithNotParsed((errors => { }));
                }
            }
            catch (Exception ex)
            {
                if (logger != null)
                {
                    logger.LogError(Strings.CriticalErrorFormat, ex.Message);
                }
            }

            //Console.WriteLine(Strings.PressEnterToExit);
            //Console.ReadLine();
        }
    }
}