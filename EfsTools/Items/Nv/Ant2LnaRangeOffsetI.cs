using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(501)]
    [Attributes(9)]
    public sealed class Ant2LnaRangeOffset
    {
        public ushort Value { get; set; }
    }
}