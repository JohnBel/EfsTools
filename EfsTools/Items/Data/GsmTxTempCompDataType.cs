using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Data
{
    [Serializable]
    public class GsmTxTempCompDataType
    {
        [ElementsCount(16)]
        [ElementType("int16")]
        [Description("")]
        public short[] TempCompPclPwrScaling { get; set; }
        
        [ElementsCount(16)]
        [ElementType("uint16")]
        [Description("")]
        public ushort[] HotTempCompPclPwrOffsetGsmk { get; set; }
        
        [ElementsCount(16)]
        [ElementType("uint16")]
        [Description("")]
        public ushort[] ColdTempCompPclPwrOffsetGsmk { get; set; }
        
        [ElementsCount(16)]
        [ElementType("uint16")]
        [Description("")]
        public ushort[] HotTempCompPclPwrOffset8psk { get; set; }
        
        [ElementsCount(16)]
        [ElementType("uint16")]
        [Description("")]
        public ushort[] ColdTempCompPclPwrOffset8psk { get; set; }
        
    }
}
