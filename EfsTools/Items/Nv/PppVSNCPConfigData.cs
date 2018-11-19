using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6247)]
    [Attributes(9)]
    public class PppVsncpConfigData
    {
        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint TermTimeout { get; set; }


        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint AckTimeout { get; set; }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort RegTry { get; set; }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort TermTry { get; set; }
    }
}