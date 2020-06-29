using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024897", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB33TxMismatchComp
    {
        [FieldCount(2)]
        public short[] TxMismatchCompType { get; set; }
    }
}