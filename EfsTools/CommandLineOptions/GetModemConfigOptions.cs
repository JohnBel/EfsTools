using CommandLine;
using EfsTools.Layouts;

namespace EfsTools.CommandLineOptions
{
    [Verb("getModemConfig", HelpText = "Get modem configuration")]
    internal class GetModemConfigOptions
    {
        [Option('p', "outComputerFilePath", Required = true, HelpText = "Output file path in computer")]
        public string OutComputerFilePath
        {
            get => _outComputerFilePathLayout?.Render();
            set
            {
                _outComputerFilePathLayout = Layout.Parse(value);
            }
        }

        private Layout _outComputerFilePathLayout;

        [Option('i', "inputComputerFilePath", Required = false, HelpText = "Input directory or MBN file path in computer")]
        public string InComputerFilePath { get; set; }

        [Option('m', "itemNames", Required = false, HelpText = "Load only this items")]
        public string ItemNames { get; set; }
    }
}