using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4749)]
    [Attributes(9)]
    public sealed class Wcdma1800HsLnaRangeRise2
    {
        public short Value { get; set; }
    }
}