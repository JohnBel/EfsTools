using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Data
{
    [Serializable]
    public class GsmTxLinearTxGainParamDataType
    {
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort GsmLinearTxGainVal { get; set; }
        
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort EdgeLinearTxGainVal { get; set; }
        
        [ElementsCount(16)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] CharpredistEnvGain { get; set; }
        
    }
}
