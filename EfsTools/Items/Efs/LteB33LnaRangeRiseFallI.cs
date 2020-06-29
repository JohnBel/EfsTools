using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024846", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB33LnaRangeRiseFall
    {
        [FieldCount(32)]
        public short[] LnaRangeRiseFallType { get; set; }
    }
}