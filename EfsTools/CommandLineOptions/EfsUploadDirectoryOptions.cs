using CommandLine;
using EfsTools.Layouts;

namespace EfsTools.CommandLineOptions
{
    [Verb("uploadDirectory", HelpText = "Upload directory from computer to EFS")]
    internal class EfsUploadDirectoryOptions
    {
        private Layout _inComputerPathLayout;

        [Option('i', "inComputerPath", Required = true, HelpText = "Input directory or MBN file path in computer ")]
        public string InComputerPath
        {
            get => _inComputerPathLayout?.Render();
            set => _inComputerPathLayout = Layout.Parse(value);
        }

        [Option('o', "outEfsPath", Required = true, HelpText = "EFS directory path")]
        public string OutEfsPath { get; set; }

        [Option('t', "createItemFilesAsDefault", Required = false, HelpText = "Create item file as default",
            Default = false)]
        public bool CreateItemFilesAsDefault { get; set; }

        [Option('v', "processNvItems", Required = false, HelpText = "Process NV items", Default = false)]
        public bool ProcessNvItems { get; set; }
    }
}