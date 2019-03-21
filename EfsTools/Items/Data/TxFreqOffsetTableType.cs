using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Data
{
    [Serializable]
    public class TxFreqOffsetTableType
    {
        [ElementsCount(8)]
        [ElementType("QMSL_Tx_Cal_Freq_Offset_Row_NV_Type")]
        [Description("")]
        public QmslTxCalFreqOffsetRowNvType[] Row { get; set; }
        
    }
}
