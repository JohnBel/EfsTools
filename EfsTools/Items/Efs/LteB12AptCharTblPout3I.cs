using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00022207", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB12AptCharTblPout3
    {
        [FieldCount(64)]
        public short[] Value { get; set; }
    }
}