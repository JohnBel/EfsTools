using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1101)]
    [Attributes(9)]
    public class Gsm850CalArfcnI
    {
        [ElementsCount(8)]
        [ElementType("int16")]
        [Description("")]
        public short[] Value { get; set; }
        
    }
}
