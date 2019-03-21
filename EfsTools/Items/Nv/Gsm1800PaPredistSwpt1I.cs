using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;
using EfsTools.Items.Data;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5369)]
    [Attributes(9)]
    public class Gsm1800PaPredistSwpt1I
    {
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort Value { get; set; }
        
    }
}
