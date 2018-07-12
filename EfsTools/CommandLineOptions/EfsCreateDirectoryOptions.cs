using CommandLine;
using CommandLine.Text;

namespace EfsTools.CommandLineOptions
{
    [Verb("createDirectory", HelpText = "Create EFS directory")]
    internal class EfsCreateDirectoryOptions
    {
        [Option('p', "path", Required = true, HelpText = "Directory path")]
        public string Path { get; set; }

        [Option('n', "noRecursive", Required = false, HelpText = "Don't create all parent directories", Default=false)]
        public bool NoRecursive { get; set; }
    }
}
