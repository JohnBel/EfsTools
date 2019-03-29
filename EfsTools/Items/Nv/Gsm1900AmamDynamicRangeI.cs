using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2749)]
    [Attributes(9)]
    public class Gsm1900AmamDynamicRange
    {
        [ElementsCount(2)]
        [ElementType("int32")]
        [Description("")]
        public int[] Value { get; set; }
        
    }
}
