using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00021379", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB1AptCharTblPaRangeList
    {
        [FieldCount(4)]
        public byte[] Value { get; set; }
    }
}