using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Data
{
    [Serializable]
    public class RfnvDataTxEtDpdType
    {
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort EtDpdIndex { get; set; }
        
        [ElementsCount(1)]
        [ElementType("QMSL_Tx_ET_DPD_AMAMs_Type")]
        [Description("")]
        public QmslTxEtDpdAmamsType Amams { get; set; }
        
        [ElementsCount(1)]
        [ElementType("QMSL_Tx_ET_DPD_AMPMs_Type")]
        [Description("")]
        public QmslTxEtDpdAmpmsType Ampms { get; set; }
        
        [ElementsCount(1)]
        [ElementType("QMSL_Tx_ET_DPD_EPDTs_Type")]
        [Description("")]
        public QmslTxEtDpdEpdtsType Epdts { get; set; }
        
    }
}
