using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024805", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB21AmprNs09
    {
        [FieldCount(16)]
        public byte[] Value { get; set; }
    }
}