using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3446)]
    [Attributes(9)]
    public class TrmConfiguration
    {
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort Config { get; set; }


        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint Mask { get; set; }
    }
}