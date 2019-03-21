using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Data
{
    [Serializable]
    public class RfnvDataTxPwrErrListType
    {
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Mod { get; set; }
        
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte ChannelIndex { get; set; }
        
        [ElementsCount(16)]
        [ElementType("int16")]
        [Description("")]
        public short[] PwrErrList { get; set; }
        
    }
}
