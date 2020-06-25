using CommandLine;
using EfsTools.Layouts;

namespace EfsTools.CommandLineOptions
{
    [Verb("downloadDirectory", HelpText = "Download EFS directory to computer")]
    internal class EfsDownloadDirectoryOptions
    {
        private Layout _outComputerPathLayout;

        [Option('i', "inEfsPath", Required = true, HelpText = "EFS directory path")]
        public string InEfsPath { get; set; }

        [Option('o', "outComputerPath", Required = true, HelpText = "Output directory path in computer")]
        public string OutComputerPath
        {
            get => _outComputerPathLayout?.Render();
            set => _outComputerPathLayout = Layout.Parse(value);
        }

        [Option('n', "noExtraData", Required = false, HelpText = "Don't save extra data in file name", Default = false)]
        public bool NoExtraData { get; set; }

        [Option('v', "processNvItems", Required = false, HelpText = "Process NV items", Default = false)]
        public bool ProcessNvItems { get; set; }
    }
}