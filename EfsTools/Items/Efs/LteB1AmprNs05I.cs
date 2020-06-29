using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00020138", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB1AmprNs05
    {
        [FieldCount(16)]
        public byte[] Value { get; set; }
    }
}