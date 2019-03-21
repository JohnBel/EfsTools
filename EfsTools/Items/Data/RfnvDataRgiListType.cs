using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Data
{
    [Serializable]
    public class RfnvDataRgiListType
    {
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Mod { get; set; }
        
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte PaState { get; set; }
        
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte ValidRgiNum { get; set; }
        
        [ElementsCount(32)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] RgiList { get; set; }
        
    }
}
