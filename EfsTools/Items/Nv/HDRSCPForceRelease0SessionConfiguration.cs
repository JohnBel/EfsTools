using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4204)]
    [Attributes(9)]
    public sealed class HdrScpForceRelease0SessionConfiguration
    {
        public byte Value { get; set; }
    }
}