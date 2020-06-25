using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(385)]
    [Attributes(9)]
    public sealed class AgcPhaseOffset
    {
        public byte Value { get; set; }
    }
}