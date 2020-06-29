using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(345)]
    [Attributes(9)]
    public sealed class PcsPdm2VsFreq
    {
        [FieldCount(16)]
        public sbyte[] Value { get; set; }
    }
}