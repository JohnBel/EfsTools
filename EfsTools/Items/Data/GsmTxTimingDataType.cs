using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Data
{
    [Serializable]
    public class GsmTxTimingDataType
    {
        [ElementsCount(1)]
        [ElementType("int16")]
        [Description("")]
        public short TxBurstOffsetAdj { get; set; }
        
        [ElementsCount(1)]
        [ElementType("int16")]
        [Description("")]
        public short PaEnStartOffsetAdj { get; set; }
        
        [ElementsCount(1)]
        [ElementType("int16")]
        [Description("")]
        public short PaEnStopOffsetAdj { get; set; }
        
        [ElementsCount(1)]
        [ElementType("int16")]
        [Description("")]
        public short PaStartOffsetAdj { get; set; }
        
        [ElementsCount(1)]
        [ElementType("int16")]
        [Description("")]
        public short PaStopOffsetAdj { get; set; }
        
        [ElementsCount(1)]
        [ElementType("int16")]
        [Description("")]
        public short AntTimingStartOffsetAdj { get; set; }
        
        [ElementsCount(1)]
        [ElementType("int16")]
        [Description("")]
        public short AntTimingStopOffsetAdj { get; set; }
        
    }
}
