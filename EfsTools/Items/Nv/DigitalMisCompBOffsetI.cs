using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(705)]
    [Attributes(9)]
    public sealed class DigitalMisCompBOffset
    {
        public int Value { get; set; }
    }
}