using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Data
{
    [Serializable]
    public class EptDpdStruct
    {
        [ElementsCount(4)]
        [ElementType("int32")]
        [Description("")]
        public int[] Am { get; set; }
        
        [ElementsCount(3)]
        [ElementType("int32")]
        [Description("")]
        public int[] Pm { get; set; }
        
        [ElementsCount(3)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] PmShift { get; set; }
        
        [ElementsCount(1)]
        [ElementType("int8")]
        [Description("")]
        public sbyte Status { get; set; }
        
    }
}
