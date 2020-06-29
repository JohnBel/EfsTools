using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(844)]
    [Attributes(9)]
    public sealed class LnaBypassTimer1
    {
        public ushort Value { get; set; }
    }
}