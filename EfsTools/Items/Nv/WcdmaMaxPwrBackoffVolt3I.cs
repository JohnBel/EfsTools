using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2715)]
    [Attributes(9)]
    public class WcdmaMaxPwrBackoffVolt3I
    {
        [ElementsCount(4)]
        [ElementType("int16")]
        [Description("")]
        public short[] Value { get; set; }
        
    }
}
