using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023874", true, 0xE1FF)]
    [Attributes(9)]
    public class Gsm1800TxGtrThreshI
    {
        [ElementsCount(1)]
        [ElementType("int8")]
        [Description("")]
        public sbyte Enable { get; set; }
        
        [ElementsCount(1)]
        [ElementType("int16")]
        [Description("")]
        public short RiseThresh { get; set; }
        
        [ElementsCount(1)]
        [ElementType("int16")]
        [Description("")]
        public short FallThresh { get; set; }
        
        [ElementsCount(1)]
        [ElementType("int16")]
        [Description("")]
        public short Reserved { get; set; }
        
    }
}
