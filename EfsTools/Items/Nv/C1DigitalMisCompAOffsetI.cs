using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(980)]
    [Attributes(9)]
    public sealed class C1DigitalMisCompAOffset
    {
        public int Value { get; set; }
    }
}