using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(702)]
    [Attributes(9)]
    public sealed class DigitalMisCompAOffset
    {
        public int Value { get; set; }
    }
}