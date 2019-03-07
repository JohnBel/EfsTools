using CommandLine;
using EfsTools.Layouts;

namespace EfsTools.CommandLineOptions
{
    [Verb("setModemConfig", HelpText = "Set modem configuration")]
    internal class SetModemConfigOptions
    {
        [Option('p', "inputComputerFilePath", Required = true, HelpText = "Input file path in computer")]
        public string InComputerFilePath { get; set; }

        [Option('o', "outComputerFilePath", Required = false, HelpText = "Output directory path in computer")]
        public string OutComputerFilePath
        {
            get => _outComputerFilePathLayout?.Render();
            set
            {
                _outComputerFilePathLayout = Layout.Parse(value);
            }
        }

        private Layout _outComputerFilePathLayout;
    }
}