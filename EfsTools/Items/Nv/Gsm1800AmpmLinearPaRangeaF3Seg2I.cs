using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5682)]
    [Attributes(9)]
    public class Gsm1800AmpmLinearPaRangeaF3Seg2I
    {
        [ElementsCount(64)]
        [ElementType("int16")]
        [Description("")]
        public short[] Value { get; set; }
        
    }
}
