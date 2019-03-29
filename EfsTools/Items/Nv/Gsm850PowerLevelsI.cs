using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3061)]
    [Attributes(9)]
    public class Gsm850PowerLevels
    {
        [ElementsCount(15)]
        [ElementType("int16")]
        [Description("")]
        public short[] Value { get; set; }
        
    }
}
