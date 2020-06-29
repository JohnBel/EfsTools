using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024061", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB10TxLimitVsTemp
    {
        [FieldCount(8)]
        public sbyte[] Value { get; set; }
    }
}