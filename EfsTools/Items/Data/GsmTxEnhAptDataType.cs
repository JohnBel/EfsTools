using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Data
{
    [Serializable]
    public class GsmTxEnhAptDataType
    {
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte PclThresholdVal { get; set; }
        
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort VbattThresholdLowPwr { get; set; }
        
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort VbattThresholdHighPwr { get; set; }
        
    }
}
