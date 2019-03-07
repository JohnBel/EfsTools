using CommandLine;
using EfsTools.Layouts;

namespace EfsTools.CommandLineOptions
{
    [Verb("writeFile", HelpText = "Write EFS file")]
    internal class EfsWriteFileOptions
    {
        [Option('i', "inComputerFilePath", Required = true, HelpText = "Computer file path")]
        public string InComputerFilePath
        {
            get => _inComputerFilePathLayout?.Render();
            set
            {
                _inComputerFilePathLayout = Layout.Parse(value);
            }
        }

        private Layout _inComputerFilePathLayout;

        [Option('o', "outEfsFilePath", Required = true, HelpText = "Output EFS path")]
        public string OutEfsFilePath { get; set; }

        [Option('n', "dontCreate", Required = false, HelpText = "Don't create EFS file if its not exist",
            Default = false)]
        public bool DontCreateEfsFile { get; set; }

        [Option('t', "item", Required = false, HelpText = "Create Item file", Default = false)]
        public bool IsItemFile { get; set; }
    }
}