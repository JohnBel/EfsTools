using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024278", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB23PaRangeMap
    {
        [FieldCount(4)]
        public sbyte[] Value { get; set; }
    }
}