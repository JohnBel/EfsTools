using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(288)]
    [Attributes(9)]
    public sealed class Pdm1VsFreq
    {
        [FieldCount(16)]
        public sbyte[] Value { get; set; }
    }
}