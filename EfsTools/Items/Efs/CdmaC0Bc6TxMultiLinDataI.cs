using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;
using EfsTools.Items.Data;

using BinarySerialization;
namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00022945", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class CdmaC0Bc6TxMultiLinData
    {
        public QmslTxCalCompleteNvType Value { get; set; }
    }
}