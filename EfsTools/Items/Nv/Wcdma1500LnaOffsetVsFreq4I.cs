using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(7011)]
    [Attributes(9)]
    public sealed class Wcdma1500LnaOffsetVsFreq4
    {
        [FieldCount(16)]
        public sbyte[] Value { get; set; }
    }
}