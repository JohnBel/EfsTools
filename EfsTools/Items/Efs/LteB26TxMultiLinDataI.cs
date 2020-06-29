using System;
using EfsTools.Attributes;
using EfsTools.Items.Data;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00024694", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB26TxMultiLinData
    {
        public QmslTxCalCompleteNvType Value { get; set; }
    }
}