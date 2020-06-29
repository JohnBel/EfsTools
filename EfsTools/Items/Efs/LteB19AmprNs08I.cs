using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024804", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB19AmprNs08
    {
        [FieldCount(16)]
        public byte[] Value { get; set; }
    }
}