using CommandLine;

namespace EfsTools.CommandLineOptions
{
    [Verb("getLog", HelpText = "Get log")]
    internal class GetLogsOptions
    {
        [Option('m', "messageMask", Required = false, HelpText = "Message packets mask")]
        public string MessageMask { get; set; }

        [Option('l', "logMask", Required = false, HelpText = "Log packets mask")]
        public string LogMask { get; set; }

        [Option('v', "verbose", Required = false, HelpText = "Verbose output")]
        public bool Verbose { get; set; }


        /*[Option('e', "eventMask", Required = false, HelpText = "Event reports mask")]
        public string EventMask { get; set; }

        [Option('f', "fileName", Required = false, HelpText = "File name")]
        public string FileName { get; set; }

        [Option('a', "layout", Required = false, HelpText = "Log layout")]
        public string Layout { get; set; }

        [Option('c', "logConfigFile", Required = false, HelpText = "NLog config file")]
        public string LogConfigFile { get; set; }*/
    }
}