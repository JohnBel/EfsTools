using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Data
{
    [Serializable]
    public class QmslTxCalCompleteNvType
    {
        [ElementsCount(1)]
        [ElementType("QMSL_Tx_Band_Cal_NV_Type")]
        [Description("")]
        public QmslTxBandCalNvType BandCalData { get; set; }
        
        [ElementsCount(192)]
        [ElementType("QMSL_Tx_Cal_Linearizer_Table_NV_Type")]
        [Description("")]
        public QmslTxCalLinearizerTableNvType[] TxLinData { get; set; }
        
    }
}
