using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(735)]
    [Attributes(9)]
    public sealed class GsmTrkLoAdjPdmGainSlope
    {
        public ushort Value { get; set; }
    }
}