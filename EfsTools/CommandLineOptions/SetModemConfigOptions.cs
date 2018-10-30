using CommandLine;

namespace EfsTools.CommandLineOptions
{
    [Verb("setModemConfig", HelpText = "Set modem configuration")]
    internal class SetModemConfigOptions
    {
        [Option('p', "outComputerFilePath", Required = true, HelpText = "Input file path in computer")]
        public string InComputerFilePath { get; set; }

        [Option('o', "outComputerFilePath", Required = false, HelpText = "Output directory path in computer")]
        public string OutComputerFilePath { get; set; }
    }
}