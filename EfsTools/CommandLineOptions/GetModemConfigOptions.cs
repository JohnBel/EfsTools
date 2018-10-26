using CommandLine;

namespace EfsTools.CommandLineOptions
{
    [Verb("getModemConfig", HelpText = "Get modem configuration")]
    internal class GetModemConfigOptions
    {
        [Option('p', "outComputerFilePath", Required = false, HelpText = "Output file path in computer")]
        public string OutComputerFilePath { get; set; }
    }
}
