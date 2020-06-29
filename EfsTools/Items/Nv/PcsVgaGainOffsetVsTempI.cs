using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(700)]
    [Attributes(9)]
    public sealed class PcsVgaGainOffsetVsTemp
    {
        [FieldCount(8)]
        public short[] Value { get; set; }
    }
}