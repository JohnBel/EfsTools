using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00023833", true, 0xE1FF)]
    [Attributes(9)]
    public class LteB8TxGtrThresh
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
        public short AdvanceTime { get; set; }
        
    }
}
