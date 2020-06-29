using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(2849)]
    [Attributes(9)]
    public sealed class Wcdma1800LnaRangeRise3
    {
        public short Value { get; set; }
    }
}