using System;
using EfsTools.Attributes;
using EfsTools.Items.Data;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00025104", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class GsmC2Gsm850TxGtrThresh
    {
        public GsmTxGtrThreshDataType GtrThresh { get; set; }
    }
}