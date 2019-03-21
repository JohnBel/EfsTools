using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2723)]
    [Attributes(9)]
    public class Wcdma800MaxPwrBackoffVolt3I
    {
        [ElementsCount(4)]
        [ElementType("int16")]
        [Description("")]
        public short[] Value { get; set; }
        
    }
}
