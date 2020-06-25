using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Items.Data;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022980", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class Wcdma1800TxMultiLinData
    {
        public QmslTxCalCompleteNvType Value { get; set; }
    }
}