using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3458)]
    [Attributes(9)]
    public sealed class HdrScpSubtypeCustomConfig
    {
        public byte CustomConfigIsActive { get; set; }


        public uint Subtype2PhysicalLayer { get; set; }


        public uint EnhancedCcmac { get; set; }


        public uint EnhancedAcmac { get; set; }


        public uint EnhancedFtcmac { get; set; }
    }
}