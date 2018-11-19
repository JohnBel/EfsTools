using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3458)]
    [Attributes(9)]
    public class HdrScpSubtypeCustomConfig
    {
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte CustomConfigIsActive { get; set; }

        [Optional]
        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint Subtype2PhysicalLayer { get; set; }

        [Optional]
        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint EnhancedCcmac { get; set; }

        [Optional]
        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint EnhancedAcmac { get; set; }

        [Optional]
        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint EnhancedFtcmac { get; set; }
    }
}