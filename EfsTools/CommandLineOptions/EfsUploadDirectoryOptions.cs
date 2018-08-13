using CommandLine;

namespace EfsTools.CommandLineOptions
{
    [Verb("uploadDirectory", HelpText = "Upload directory from computer to EFS")]
    internal class EfsUploadDirectoryOptions
    {
        [Option('i', "inComputerPath", Required = true, HelpText = "Input directory path in computer")]
        public string InComputerPath { get; set; }
        [Option('o', "outEfsPath", Required = true, HelpText = "EFS directory path")]
        public string OutEfsPath { get; set; }
        [Option('t', "createItemFilesAsDefault", Required = false, HelpText = "Create item file as default", Default = false)]
        public bool CreateItemFilesAsDefault { get; set; }
    }
}
