using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00023580", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB39PaRangeMap
    {
        [FieldCount(4)]
        public sbyte[] Value { get; set; }
    }
}