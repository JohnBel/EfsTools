using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6832)]
    [Attributes(9)]
    public sealed class HdrScpForceRestrictedCf
    {
        public byte Value { get; set; }
    }
}