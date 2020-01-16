using CommandLine;
using EfsTools.Layouts;

namespace EfsTools.CommandLineOptions
{
    [Verb("readFile", HelpText = "Read EFS file")]
    internal class EfsReadFileOptions
    {
        private Layout _outComputerFilePathLayout;

        [Option('i', "inEfsFilePath", Required = true, HelpText = "EFS file path")]
        public string InEfsFilePath { get; set; }

        [Option('o', "outComputerFilePath", Required = true, HelpText = "Output file path in computer")]
        public string OutComputerFilePath
        {
            get => _outComputerFilePathLayout?.Render();
            set => _outComputerFilePathLayout = Layout.Parse(value);
        }

        [Option('s', "subscriptionIndex", Required = false, HelpText = "Subscription index. 0 - first SIM, 1 - second SIM", Default = 0)]
        public int SubscriptionIndex { get; set; }
    }
}