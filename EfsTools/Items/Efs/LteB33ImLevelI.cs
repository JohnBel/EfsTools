using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024848", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB33ImLevel
    {
        [FieldCount(16)]
        public short[] ImLevel { get; set; }
    }
}