using System;
using EfsTools.Attributes;
using EfsTools.Items.Data;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00025697", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB23TxLinVsTempVsFreqPIn
    {
        public byte Enabled { get; set; }

        [FieldCount(4)]
        public QmslTxLinVsTempVsFreqNumType[] PaState { get; set; }
    }
}