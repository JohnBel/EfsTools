using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4964)]
    [Attributes(9)]
    public sealed class HdrScpForceAtConfiguration
    {
        public ushort Value { get; set; }
    }
}