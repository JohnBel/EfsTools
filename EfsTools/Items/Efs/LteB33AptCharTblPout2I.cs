using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024920", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB33AptCharTblPout2
    {
        [FieldCount(64)]
        public short[] Value { get; set; }
    }
}