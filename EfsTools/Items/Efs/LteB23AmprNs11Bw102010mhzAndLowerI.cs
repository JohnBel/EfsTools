using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024809", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB23AmprNs11Bw102010mhzAndLower
    {
        [FieldCount(16)]
        public byte[] Value { get; set; }
    }
}