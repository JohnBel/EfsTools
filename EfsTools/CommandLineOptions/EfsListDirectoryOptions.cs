using CommandLine;

namespace EfsTools.CommandLineOptions
{
    [Verb("listDirectory", HelpText = "List EFS directory")]
    internal class EfsListDirectoryOptions
    {
        [Option('p', "path", Required = true, HelpText = "Directory path")]
        public string Path { get; set; }

        [Option('r', "recursive", Required = false, HelpText = "List all parent directories", Default = false)]
        public bool Recursive { get; set; }
    }
}