using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(327)]
    [Attributes(9)]
    public sealed class PcsRxCompVsFreq
    {
        [FieldCount(16)]
        public sbyte[] Value { get; set; }
    }
}