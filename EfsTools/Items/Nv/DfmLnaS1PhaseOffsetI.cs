using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(618)]
    [Attributes(9)]
    public sealed class DfmLnaS1PhaseOffset
    {
        public ushort Value { get; set; }
    }
}