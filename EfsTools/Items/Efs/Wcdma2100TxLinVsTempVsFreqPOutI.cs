using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Items.Data;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025624", true, 0xE1FF)]
    [Attributes(9)]
    public class Wcdma2100TxLinVsTempVsFreqPOutI
    {
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Reserved { get; set; }
        
        [ElementsCount(4)]
        [ElementType("QMSL_Tx_Lin_Vs_Temp_Vs_Freq_Num_Type")]
        [Description("")]
        public QmslTxLinVsTempVsFreqNumType[] PaState { get; set; }
        
    }
}
