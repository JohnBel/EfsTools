using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6828)]
    [Attributes(9)]
    public class LteBcConfig
    {
        [ElementsCount(2)]
        [ElementType("uint64")]
        [Description("")]
        public ulong[] Value { get; set; }
        
    }
}
