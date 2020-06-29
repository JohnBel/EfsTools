using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024821", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB26AmprNs15Bw15845mhzAndHigher
    {
        [FieldCount(16)]
        public byte[] Value { get; set; }
    }
}