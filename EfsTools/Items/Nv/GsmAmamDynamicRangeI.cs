using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2743)]
    [Attributes(9)]
    public class GsmAmamDynamicRangeI
    {
        [ElementsCount(2)]
        [ElementType("int32")]
        [Description("")]
        public int[] Value { get; set; }
        
    }
}
