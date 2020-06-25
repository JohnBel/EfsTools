using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(704)]
    [Attributes(9)]
    public sealed class FmMisCompBOffset
    {
        public int Value { get; set; }
    }
}