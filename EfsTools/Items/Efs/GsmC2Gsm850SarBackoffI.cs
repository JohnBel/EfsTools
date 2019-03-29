using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Items.Data;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025032", true, 0xE1FF)]
    [Attributes(9)]
    public class GsmC2Gsm850SarBackoff
    {
        [ElementsCount(8)]
        [ElementType("GSM_TX_SAR_BACKOFF_DATA_TYPE")]
        [Description("")]
        public GsmTxSarBackoffDataType[] SarBackOffLimitSlot1 { get; set; }
        
        [ElementsCount(8)]
        [ElementType("GSM_TX_SAR_BACKOFF_DATA_TYPE")]
        [Description("")]
        public GsmTxSarBackoffDataType[] SarBackOffLimitSlot2 { get; set; }
        
        [ElementsCount(8)]
        [ElementType("GSM_TX_SAR_BACKOFF_DATA_TYPE")]
        [Description("")]
        public GsmTxSarBackoffDataType[] SarBackOffLimitSlot3 { get; set; }
        
        [ElementsCount(8)]
        [ElementType("GSM_TX_SAR_BACKOFF_DATA_TYPE")]
        [Description("")]
        public GsmTxSarBackoffDataType[] SarBackOffLimitSlot4 { get; set; }
        
        [ElementsCount(8)]
        [ElementType("GSM_TX_SAR_BACKOFF_DATA_TYPE")]
        [Description("")]
        public GsmTxSarBackoffDataType[] SarBackOffLimitSlot5 { get; set; }
        
    }
}
