using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/modem/1x/zz2_2_thresh", true, 0xE1FF)]
    [Attributes(9)]
    public class Zz22Thresh
    {
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Field1 { get; set; }


        [ElementsCount(1)]
        [ElementType("int8")]
        [Description("")]
        public sbyte Field2 { get; set; }


        [ElementsCount(1)]
        [ElementType("int16")]
        [Description("")]
        public short Field3 { get; set; }


        [ElementsCount(1)]
        [ElementType("int8")]
        [Description("")]
        public sbyte Field4 { get; set; }


        [ElementsCount(1)]
        [ElementType("int16")]
        [Description("")]
        public short Field5 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Field6 { get; set; }
    }
}