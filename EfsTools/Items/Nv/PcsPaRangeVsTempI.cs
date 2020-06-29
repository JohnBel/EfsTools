using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(352)]
    [Attributes(9)]
    public sealed class PcsPaRangeVsTemp
    {
        [FieldCount(8)]
        public sbyte[] Value { get; set; }
    }
}