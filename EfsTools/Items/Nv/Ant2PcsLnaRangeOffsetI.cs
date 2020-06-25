using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(510)]
    [Attributes(9)]
    public sealed class Ant2PcsLnaRangeOffset
    {
        public ushort Value { get; set; }
    }
}