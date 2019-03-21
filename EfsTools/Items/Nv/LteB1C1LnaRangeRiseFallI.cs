using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6742)]
    [Attributes(9)]
    public class LteB1C1LnaRangeRiseFallI
    {
        [ElementsCount(32)]
        [ElementType("int16")]
        [Description("")]
        public short[] Value { get; set; }
        
    }
}
