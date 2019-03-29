using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6829)]
    [Attributes(9)]
    public class LteBcConfigDiv
    {
        [ElementsCount(2)]
        [ElementType("uint64")]
        [Description("")]
        public ulong[] Value { get; set; }
        
    }
}
