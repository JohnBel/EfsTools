using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(703)]
    [Attributes(9)]
    public sealed class GpsMisCompAOffset
    {
        public int Value { get; set; }
    }
}