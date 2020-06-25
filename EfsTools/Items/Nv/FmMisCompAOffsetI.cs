using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(701)]
    [Attributes(9)]
    public sealed class FmMisCompAOffset
    {
        public int Value { get; set; }
    }
}