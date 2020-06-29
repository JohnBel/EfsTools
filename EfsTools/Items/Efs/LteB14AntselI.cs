using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024393", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB14Antsel
    {
        [FieldCount(4)]
        public byte[] Value { get; set; }
    }
}