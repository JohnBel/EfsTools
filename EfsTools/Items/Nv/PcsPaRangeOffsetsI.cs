using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(435)]
    [Attributes(9)]
    public sealed class PcsPaRangeOffsets
    {
        [FieldCount(4)]
        public short[] Value { get; set; }
    }
}