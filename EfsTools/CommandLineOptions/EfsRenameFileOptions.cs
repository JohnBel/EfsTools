using CommandLine;

namespace EfsTools.CommandLineOptions
{
    [Verb("renameFile", HelpText = "Rename (move) EFS file")]
    internal class EfsRenameFileOptions
    {
        [Option('p', "efsFilePath", Required = true, HelpText = "EFS file path")]
        public string EfsFilePath { get; set; }
        [Option('n', "efsNewFilePath", Required = true, HelpText = "New EFS file path")]
        public string NewEfsFilePath { get; set; }
    }
}
