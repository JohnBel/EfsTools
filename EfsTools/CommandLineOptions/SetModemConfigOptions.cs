using CommandLine;

namespace EfsTools.CommandLineOptions
{
    [Verb("setModemConfig", HelpText = "Set modem configuration")]
    internal class SetModemConfigOptions
    {
        [Option('p', "outComputerFilePath", Required = false, HelpText = "Input file path in computer")]
        public string InComputerFilePath { get; set; }
    }
}
