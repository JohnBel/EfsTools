namespace EfsTools.Mbn
{
    internal class McfgHeader
    {
        public string Magic { get; set; }
        public ushort FormatType { get; set; }
        public ConfigurationType ConfigurationType { get; set; }
        public uint ItemsCount { get; set; }
        public ushort CarrierIndex { get; set; }
        public ushort Reserved { get; set; }
        public uint Version { get; set; }
    }
}