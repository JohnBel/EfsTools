using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024820", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB26AmprNs15Bw10845mhzAndHigher
    {
        [FieldCount(16)]
        public byte[] Value { get; set; }
    }
}