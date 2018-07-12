using CommandLine;

namespace EfsTools.CommandLineOptions
{
    [Verb("deleteDirectory", HelpText = "Delete EFS directory")]
    internal class EfsDeleteDirectoryOptions
    {
        [Option('p', "path", Required = true, HelpText = "Directory path")]
        public string Path { get; set; }

        [Option('n', "noRecursive", Required = false, HelpText = "Don't delete all children directories", Default=false)]
        public bool NoRecursive { get; set; }
    }
}
