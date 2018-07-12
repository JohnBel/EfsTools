using CommandLine;

namespace EfsTools.CommandLineOptions
{
    [Verb("deleteFile", HelpText = "Delete EFS file")]
    internal class EfsDeleteFileOptions
    {
        [Option('p', "path", Required = true, HelpText = "File path")]
        public string Path { get; set; }
    }
}
