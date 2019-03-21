using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5432)]
    [Attributes(9)]
    public class ProcessCalI
    {
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort Value1 { get; set; }
        
        [ElementsCount(3)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] Value2 { get; set; }
        
    }
}
