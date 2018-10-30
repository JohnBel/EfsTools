using CommandLine;

namespace EfsTools.CommandLineOptions
{
    [Verb("getModemConfig", HelpText = "Get modem configuration")]
    internal class GetModemConfigOptions
    {
        [Option('p', "outComputerFilePath", Required = true, HelpText = "Output file path in computer")]
        public string OutComputerFilePath { get; set; }

        [Option('i', "inputComputerFilePath", Required = false, HelpText = "Input directory path in computer")]
        public string InComputerFilePath { get; set; }
    }
}