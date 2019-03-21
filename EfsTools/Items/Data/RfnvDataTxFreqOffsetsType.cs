using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Data
{
    [Serializable]
    public class RfnvDataTxFreqOffsetsType
    {
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte PaState { get; set; }
        
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte FcompSweepType { get; set; }
        
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort FcompIndex { get; set; }
        
        [ElementsCount(1)]
        [ElementType("QMSL_Tx_Cal_Freq_Offsets_Type")]
        [Description("")]
        public QmslTxCalFreqOffsetsType FreqOffsets { get; set; }
        
    }
}
