using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Data
{
    [Serializable]
    public class GsmRxLnaSwptType
    {
        [ElementsCount(1)]
        [ElementType("int8")]
        [Description("")]
        public sbyte MaxGainrange1 { get; set; }
        
        [ElementsCount(1)]
        [ElementType("int8")]
        [Description("")]
        public sbyte MinGainrange2 { get; set; }
        
        [ElementsCount(1)]
        [ElementType("int8")]
        [Description("")]
        public sbyte MaxGainrange2 { get; set; }
        
        [ElementsCount(1)]
        [ElementType("int8")]
        [Description("")]
        public sbyte MinGainrange3 { get; set; }
        
        [ElementsCount(1)]
        [ElementType("int8")]
        [Description("")]
        public sbyte MaxGainrange3 { get; set; }
        
        [ElementsCount(1)]
        [ElementType("int8")]
        [Description("")]
        public sbyte MinGainrange4 { get; set; }
        
        [ElementsCount(1)]
        [ElementType("int8")]
        [Description("")]
        public sbyte MaxGainrange4 { get; set; }
        
        [ElementsCount(1)]
        [ElementType("int8")]
        [Description("")]
        public sbyte MinGainrange5 { get; set; }
        
    }
}
