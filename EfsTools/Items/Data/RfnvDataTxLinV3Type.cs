using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Data
{
    [Serializable]
    public class RfnvDataTxLinV3Type
    {
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte PaState { get; set; }
        
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte WaveType { get; set; }
        
        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint TxChan { get; set; }
        
        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint UpperBoundTxChan { get; set; }
        
        [ElementsCount(1)]
        [ElementType("QMSL_Tx_Lin_V3_RGIs_Type")]
        [Description("")]
        public QmslTxLinV3RgisType Rgis { get; set; }
        
        [ElementsCount(1)]
        [ElementType("QMSL_Tx_Lin_V3_PWRs_Type")]
        [Description("")]
        public QmslTxLinV3PwrsType PwrsDb10 { get; set; }
        
        [ElementsCount(1)]
        [ElementType("QMSL_Tx_Lin_V3_APTs_Type")]
        [Description("")]
        public QmslTxLinV3AptsType Apts { get; set; }
        
        [ElementsCount(1)]
        [ElementType("QMSL_Tx_Lin_V3_PA_Currents_Type")]
        [Description("")]
        public QmslTxLinV3PaCurrentsType Currents { get; set; }
        
        [ElementsCount(1)]
        [ElementType("QMSL_Tx_Lin_V3_IQ_Offsets_Type")]
        [Description("")]
        public QmslTxLinV3IqOffsetsType IqOffsets { get; set; }
        
        [ElementsCount(1)]
        [ElementType("QMSL_Tx_Lin_V3_DPD_Info_Type")]
        [Description("")]
        public QmslTxLinV3DpdInfoType DpdInfo { get; set; }
        
        [ElementsCount(1)]
        [ElementType("QMSL_Tx_Lin_V3_FComp_Index_Type")]
        [Description("")]
        public QmslTxLinV3FcompIndexType FcompInfo { get; set; }
        
    }
}
