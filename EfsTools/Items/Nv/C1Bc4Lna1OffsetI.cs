using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1524)]
    [Attributes(9)]
    public sealed class C1Bc4Lna1Offset
    {
        public short Value { get; set; }
    }
}