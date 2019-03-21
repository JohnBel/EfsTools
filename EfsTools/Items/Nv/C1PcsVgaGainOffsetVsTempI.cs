using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(979)]
    [Attributes(9)]
    public class C1PcsVgaGainOffsetVsTempI
    {
        [ElementsCount(8)]
        [ElementType("int16")]
        [Description("")]
        public short[] Value { get; set; }
        
    }
}
