using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(843)]
    [Attributes(9)]
    public sealed class LnaBypassTimer0
    {
        public ushort Value { get; set; }
    }
}