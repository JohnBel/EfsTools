using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(2857)]
    [Attributes(9)]
    public sealed class Wcdma1800LnaOffsetVsFreq3
    {
        [FieldCount(16)]
        public sbyte[] Value { get; set; }
    }
}