using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(889)]
    [Attributes(41)]
    public class DataServicesMobileIpDmuMnAuthentication
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
        [ElementType("int8")]
        [Description("")]
        public sbyte Field3 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Field4 { get; set; }
    }
}