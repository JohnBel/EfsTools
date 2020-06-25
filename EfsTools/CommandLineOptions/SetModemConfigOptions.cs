using CommandLine;
using EfsTools.Layouts;

namespace EfsTools.CommandLineOptions
{
    [Verb("setModemConfig", HelpText = "Set modem configuration")]
    internal class SetModemConfigOptions
    {
        private Layout _outComputerFilePathLayout;

        [Option('p', "inputComputerFilePath", Required = true, HelpText = "Input file path in computer")]
        public string InComputerFilePath { get; set; }

        [Option('o', "outComputerFilePath", Required = false, HelpText = "Output directory path in computer")]
        public string OutComputerFilePath
        {
            get => _outComputerFilePathLayout?.Render();
            set => _outComputerFilePathLayout = Layout.Parse(value);
        }

        [Option('s', "subscriptionIndex", Required = false,
            HelpText = "Subscription index. 0 - first SIM, 1 - second SIM", Default = 0)]
        public int SubscriptionIndex { get; set; }
    }
}