using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024888", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB33C1ImLevel
    {
        [FieldCount(16)]
        public short[] C1ImLevel { get; set; }
    }
}