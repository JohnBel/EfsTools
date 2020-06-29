using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00021416", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB4AptCharTblPout2
    {
        [FieldCount(64)]
        public short[] Value { get; set; }
    }
}