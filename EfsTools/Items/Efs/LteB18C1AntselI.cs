using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00020369", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB18C1Antsel
    {
        [FieldCount(4)]
        public byte[] Value { get; set; }
    }
}