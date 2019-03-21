using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2937)]
    [Attributes(9)]
    public class Wcdma1800MaxPwrBackoffVolt2I
    {
        [ElementsCount(4)]
        [ElementType("int16")]
        [Description("")]
        public short[] Value { get; set; }
        
    }
}
