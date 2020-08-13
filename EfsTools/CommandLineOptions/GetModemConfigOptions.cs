using CommandLine;
using EfsTools.Layouts;

namespace EfsTools.CommandLineOptions
{
    [Verb("getModemConfig", HelpText = "Get modem configuration")]
    internal class GetModemConfigOptions
    {
        private Layout _outComputerFilePathLayout;

        [Option('p', "outComputerFilePath", Required = true, HelpText = "Output file path in computer")]
        public string OutComputerFilePath
        {
            get => _outComputerFilePathLayout?.Render();
            set => _outComputerFilePathLayout = Layout.Parse(value);
        }

        [Option('i', "inputComputerFilePath", Required = false,
            HelpText = "Input directory or MBN file path in computer")]
        public string InComputerFilePath { get; set; }

        [Option('m', "itemNames", Required = false, HelpText = "Load only this items")]
        public string ItemNames { get; set; }

        [Option('s', "subscriptionIndex", Required = false,
            HelpText = "Subscription index. 0 - first SIM, 1 - second SIM", Default = 0)]
        public int SubscriptionIndex { get; set; }

        [Option('v', "verbose", Required = false, HelpText = "Verbose output")]
        public bool Verbose { get; set; }
    }
}