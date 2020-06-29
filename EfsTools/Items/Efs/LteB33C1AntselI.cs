using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024885", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB33C1Antsel
    {
        [FieldCount(4)]
        public byte[] C1Antsel { get; set; }
    }
}