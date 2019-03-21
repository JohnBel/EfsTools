using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2704)]
    [Attributes(9)]
    public class WcdmaPaCompensateUpWithDvsI
    {
        [ElementsCount(10)]
        [ElementType("int16")]
        [Description("")]
        public short[] Value { get; set; }
        
    }
}
