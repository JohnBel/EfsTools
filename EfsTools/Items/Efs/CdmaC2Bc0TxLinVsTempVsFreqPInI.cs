using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;
using EfsTools.Items.Data;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00025601", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc0TxLinVsTempVsFreqPIn
    {
        public byte Reserved { get; set; }

        [FieldCount(4)]
        public QmslTxLinVsTempVsFreqNumType[] PaState
        {
            get;
        }
    }
}