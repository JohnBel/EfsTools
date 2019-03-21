using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Data
{
    [Serializable]
    public class GsmTxVbattCompDataType
    {
        [ElementsCount(1)]
        [ElementType("int16")]
        [Description("")]
        public short VbattCompDbx100 { get; set; }
        
        [ElementsCount(4)]
        [ElementType("int16")]
        [Description("")]
        public short[] VbattCompParangeDbx100 { get; set; }
        
    }
}
