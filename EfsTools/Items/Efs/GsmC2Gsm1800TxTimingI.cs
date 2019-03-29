using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;
using EfsTools.Items.Data;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024986", true, 0xE1FF)]
    [Attributes(9)]
    public class GsmC2Gsm1800TxTiming
    {
        [ElementsCount(1)]
        [ElementType("GSM_TX_TIMING_DATA_TYPE")]
        [Description("")]
        public GsmTxTimingDataType GsmTxTimingData { get; set; }
        
    }
}
