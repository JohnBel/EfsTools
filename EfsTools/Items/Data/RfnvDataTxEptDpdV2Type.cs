using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Data
{
    [Serializable]
    public class RfnvDataTxEptDpdV2Type
    {
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort EptDpdIndex { get; set; }
        
        [ElementsCount(1)]
        [ElementType("QMSL_Tx_EPT_DPD_V2_AMAMs_Type")]
        [Description("")]
        public QmslTxEptDpdV2AmamsType Amams { get; set; }
        
        [ElementsCount(1)]
        [ElementType("QMSL_Tx_EPT_DPD_V2_AMPMs_Type")]
        [Description("")]
        public QmslTxEptDpdV2AmpmsType Ampms { get; set; }
        
    }
}
