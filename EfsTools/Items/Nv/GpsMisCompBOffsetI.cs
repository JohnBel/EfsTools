using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(706)]
    [Attributes(9)]
    public sealed class GpsMisCompBOffset
    {
        public int Value { get; set; }
    }
}