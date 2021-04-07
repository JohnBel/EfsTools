using CommandLine;

namespace EfsTools.CommandLineOptions
{
    [Verb("webDavServer", HelpText = "Start WebDAV server")]
    internal class StartWebDavServerOptions
    {
        [Option('p', "port", Required = true, HelpText = "Port number")]
        public int Port { get; set; }

        [Option('l', "logLevel", Required = false, HelpText = "Log level (Info, Warning, Error)", Default = global::EfsTools.LogLevel.Info)]
        public LogLevel LogLevel { get; set; }

        [Option('r', "readOnly", Required = false, HelpText = "ReadOnly", Default = 1)]
        public int ReadOnly { get; set; }
    }
}