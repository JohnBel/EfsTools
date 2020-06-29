using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4416)]
    [Attributes(9)]
    public sealed class Wcdma1800LnaOffsetVsFreq4
    {
        [FieldCount(16)]
        public sbyte[] Value { get; set; }
    }
}