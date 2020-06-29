using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00025124", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB23AmprNs11Bw152012p5mhzAndLower
    {
        [FieldCount(16)]
        public short[] Value { get; set; }
    }
}