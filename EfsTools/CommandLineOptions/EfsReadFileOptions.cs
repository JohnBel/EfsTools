using CommandLine;

namespace EfsTools.CommandLineOptions
{
    [Verb("readFile", HelpText = "Read EFS file")]
    internal class EfsReadFileOptions
    {
        [Option('i', "inEfsFilePath", Required = true, HelpText = "EFS file path")]
        public string InEfsFilePath { get; set; }
        [Option('o', "outComputerFilePath", Required = false, HelpText = "Output file path in computer")]
        public string OutComputerFilePath { get; set; }
    }
}
