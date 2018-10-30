using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1897)]
    [Attributes(9)]
    public class Ipv6StateMachineConfiguration
    {
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort Field1 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort Field2 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort Field3 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort Field4 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort Field5 { get; set; }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort Field6 { get; set; }
    }
}