using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Data
{
    [Serializable]
    public class GsmTxSarBackoffDataType
    {
        [ElementsCount(1)]
        [ElementType("int16")]
        [Description("")]
        public short SarGmsk { get; set; }
        
        [ElementsCount(1)]
        [ElementType("int16")]
        [Description("")]
        public short Sar8psk { get; set; }
        
    }
}
