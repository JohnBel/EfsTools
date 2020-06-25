using CommandLine;
using EfsTools.Layouts;

namespace EfsTools.CommandLineOptions
{
    [Verb("extractMbn", HelpText = "Extract 'Modem configuration BiNary' file to computer")]
    internal class ExtractMbnOptions
    {
        private Layout _outputComputerDirectoryPathLayout;

        [Option('i', "inputMbnFilePath", Required = true, HelpText = "Input MBN file path")]
        public string InputMbnFilePath { get; set; }

        [Option('p', "outputComputerDirectoryPath", Required = true, HelpText = "Output directory path in computer")]
        public string OutputComputerDirectoryPath
        {
            get => _outputComputerDirectoryPathLayout?.Render();
            set => _outputComputerDirectoryPathLayout = Layout.Parse(value);
        }

        [Option('n', "noExtraData", Required = false, HelpText = "Don't save extra data in file name", Default = false)]
        public bool NoExtraData { get; set; }
    }
}