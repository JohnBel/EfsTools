using CommandLine;

namespace EfsTools.CommandLineOptions
{
    [Verb("extractMbn", HelpText = "Extract 'Modem configuration BiNary' file to computer")]
    internal class ExtractMbnOptions
    {
        [Option('i', "inputMbnFilePath", Required = true, HelpText = "Input MBN file path")]
        public string InputMbnFilePath { get; set; }

        [Option('p', "outputComputerDirectoryPath", Required = true, HelpText = "Output directory path in computer")]
        public string OutputComputerDirectoryPath { get; set; }

        [Option('n', "noExtraData", Required = false, HelpText = "Don't save extra data in file name", Default = false)]
        public bool NoExtraData { get; set; }
    }
}