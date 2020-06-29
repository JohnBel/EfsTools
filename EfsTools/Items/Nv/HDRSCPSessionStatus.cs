using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(475)]
    [Attributes(9)]
    public sealed class HdrScpSessionStatus
    {
        public ushort Value { get; set; }
    }
}