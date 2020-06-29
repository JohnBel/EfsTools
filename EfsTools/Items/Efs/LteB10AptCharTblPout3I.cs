using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024112", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB10AptCharTblPout3
    {
        [FieldCount(64)]
        public short[] Value { get; set; }
    }
}