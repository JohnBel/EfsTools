using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023218", true, 0xE1FF)]
    [Attributes(9)]
    public class CdmaC0Bc14TxPwrTempComp
    {
        [ElementsCount(1)]
        [ElementType("int8")]
        [Description("")]
        public sbyte Reserved { get; set; }
        
        [ElementsCount(8)]
        [ElementType("int8")]
        [Description("")]
        public sbyte[] Pa0PowerOffset { get; set; }
        
        [ElementsCount(8)]
        [ElementType("int16")]
        [Description("")]
        public short[] Pa0PowerSlope { get; set; }
        
        [ElementsCount(8)]
        [ElementType("int8")]
        [Description("")]
        public sbyte[] Pa1PowerOffset { get; set; }
        
        [ElementsCount(8)]
        [ElementType("int16")]
        [Description("")]
        public short[] Pa1PowerSlope { get; set; }
        
        [ElementsCount(8)]
        [ElementType("int8")]
        [Description("")]
        public sbyte[] Pa2PowerOffset { get; set; }
        
        [ElementsCount(8)]
        [ElementType("int16")]
        [Description("")]
        public short[] Pa2PowerSlope { get; set; }
        
        [ElementsCount(8)]
        [ElementType("int8")]
        [Description("")]
        public sbyte[] Pa3PowerOffset { get; set; }
        
        [ElementsCount(8)]
        [ElementType("int16")]
        [Description("")]
        public short[] Pa3PowerSlope { get; set; }
        
    }
}
