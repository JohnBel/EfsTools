using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(157)]
    [Attributes(9)]
    public sealed class LnaRangeRise
    {
        public sbyte Value { get; set; }
    }
}