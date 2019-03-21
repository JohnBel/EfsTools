using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Data
{
    [Serializable]
    public class QmslRxSpurTableNvType
    {
        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint AbsFreqHz { get; set; }
        
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte NotchSetting { get; set; }
        
    }
}
