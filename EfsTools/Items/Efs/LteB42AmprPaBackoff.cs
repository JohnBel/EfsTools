using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024509", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB42AmprPaBackoff
    {
        [FieldCount(2)]
        public byte[] Value { get; set; }
    }
}