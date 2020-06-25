using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(617)]
    [Attributes(9)]
    public sealed class DfmLnaS0PhaseOffset
    {
        public ushort Value { get; set; }
    }
}