using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6993)]
    [Attributes(9)]
    public class Wcdma1500PaCompensateUpWithDvsI
    {
        [ElementsCount(10)]
        [ElementType("int16")]
        [Description("")]
        public short[] Value { get; set; }
        
    }
}
