namespace EfsTools.Mbn
{
    internal class ItemHeader
    {
        public uint Length { get; set; }
        public byte Attributes { get; set; }
        public ItemType Type { get; set; }
        public ushort Reserved { get; set; }
    }
}