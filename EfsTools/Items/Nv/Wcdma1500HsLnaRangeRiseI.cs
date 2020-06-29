using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(7060)]
    [Attributes(9)]
    public sealed class Wcdma1500HsLnaRangeRise
    {
        public short Value { get; set; }
    }
}