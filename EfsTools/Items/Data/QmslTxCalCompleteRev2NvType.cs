using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Data
{
    [Serializable]
    public class QmslTxCalCompleteRev2NvType
    {
        [ElementsCount(1)]
        [ElementType("QMSL_Tx_Band_Cal_Rev2_NV_Type")]
        [Description("")]
        public QmslTxBandCalRev2NvType BandCalData { get; set; }
        
        [ElementsCount(192)]
        [ElementType("QMSL_Tx_Cal_Linearizer_Table_NV_Type")]
        [Description("")]
        public QmslTxCalLinearizerTableNvType[] TxLinData { get; set; }
        
        [ElementsCount(32)]
        [ElementType("QMSL_Tx_Cal_Linearizer_EPT_DPD_Table_NV_Type")]
        [Description("")]
        public QmslTxCalLinearizerEptDpdTableNvType[] TxDpdData { get; set; }
        
    }
}
