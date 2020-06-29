using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00022345", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB25TxMismatchComp
    {
        [FieldCount(2)]
        public short[] Value { get; set; }
    }
}