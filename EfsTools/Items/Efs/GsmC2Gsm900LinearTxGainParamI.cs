using System;
using EfsTools.Attributes;
using EfsTools.Items.Data;

namespace EfsTools.Items.Efs
{
    [Serializable]
        [EfsFile("/nv/item_files/rfnv/00025057", true, 0xE1FF)]
    [Attributes(9)]
    public sealed class GsmC2Gsm900LinearTxGainParam
    {
        public GsmTxLinearTxGainParamDataType TxGainParam { get; set; }
    }
}