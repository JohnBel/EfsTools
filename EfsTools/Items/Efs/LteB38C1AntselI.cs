using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00020424", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB38C1Antsel
    {
        [FieldCount(4)]
        public byte[] Value { get; set; }
    }
}