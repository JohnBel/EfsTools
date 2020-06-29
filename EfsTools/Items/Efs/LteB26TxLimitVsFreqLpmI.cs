using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024705", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB26TxLimitVsFreqLpm
    {
        [FieldCount(16)]
        public sbyte[] LteTxLimitVsFreqLpm { get; set; }
    }
}