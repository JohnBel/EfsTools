using System;
using EfsTools.Attributes;
using EfsTools.Items.Data;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00025102", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class GsmC0Gsm1800TxGtrThresh
    {
        public GsmTxGtrThreshDataType GtrThresh { get; set; }
    }
}