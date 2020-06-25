using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1226)]
    [Attributes(9)]
    public sealed class C1Bc6LnaRangeOffset
    {
        public ushort Value { get; set; }
    }
}