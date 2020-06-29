using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;
using EfsTools.Items.Data;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00022954", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC2Bc10TxMultiLinData
    {
        public QmslTxCalCompleteNvType Value { get; set; }
    }
}