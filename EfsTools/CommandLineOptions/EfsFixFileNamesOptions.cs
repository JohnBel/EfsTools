using CommandLine;

namespace EfsTools.CommandLineOptions
{
    [Verb("fixFileNames", HelpText = "Fix invalid file names")]
    internal class EfsFixFileNamesOptions
    {
        [Option('p', "efsPath", Required = true, HelpText = "EFS directory path")]
        public string EfsPath { get; set; }
    }
}
