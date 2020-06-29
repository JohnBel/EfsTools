using System;
using EfsTools.Attributes;
using EfsTools.Items.Data;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00022973", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class LteB38TxMultiLinData
    {
        public QmslTxCalCompleteNvType Value { get; set; }
    }
}