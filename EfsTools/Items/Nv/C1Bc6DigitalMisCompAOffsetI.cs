using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1267)]
    [Attributes(9)]
    public sealed class C1Bc6DigitalMisCompAOffset
    {
        public int Value { get; set; }
    }
}