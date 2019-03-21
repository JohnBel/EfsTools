using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4387)]
    [Attributes(9)]
    public class DcsRxGainRange4TempCompI
    {
        [ElementsCount(3)]
        [ElementType("int16")]
        [Description("")]
        public short[] Value { get; set; }
        
    }
}
