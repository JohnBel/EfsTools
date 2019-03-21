using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2713)]
    [Attributes(9)]
    public class WcdmaMaxPwrBackoffVolt1I
    {
        [ElementsCount(4)]
        [ElementType("int16")]
        [Description("")]
        public short[] Value { get; set; }
        
    }
}
