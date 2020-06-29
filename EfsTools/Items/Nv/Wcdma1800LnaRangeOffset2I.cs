using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(2854)]
    [Attributes(9)]
    public sealed class Wcdma1800LnaRangeOffset2
    {
        public short Value { get; set; }
    }
}