using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(2868)]
    [Attributes(9)]
    public sealed class Wcdma1800LnaRangeOffset
    {
        public short Value { get; set; }
    }
}