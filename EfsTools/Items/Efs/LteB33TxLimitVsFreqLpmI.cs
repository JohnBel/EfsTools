using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024901", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB33TxLimitVsFreqLpm
    {
        [FieldCount(16)]
        public sbyte[] LteTxLimitVsFreqLpm { get; set; }
    }
}