using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(7147)]
    [Attributes(9)]
    public class DataCallOverEhrpdOnly
    {
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Field1 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Field2 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Field3 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Field4 { get; set; }
    }
}