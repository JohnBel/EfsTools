using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4212)]
    [Attributes(9)]
    public class XoTrimValues
    {
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Current { get; set; }
        
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Table { get; set; }
        
    }
}
