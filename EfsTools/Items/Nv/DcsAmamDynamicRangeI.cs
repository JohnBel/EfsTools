using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2745)]
    [Attributes(9)]
    public class DcsAmamDynamicRange
    {
        [ElementsCount(2)]
        [ElementType("int32")]
        [Description("")]
        public int[] Value { get; set; }
        
    }
}
