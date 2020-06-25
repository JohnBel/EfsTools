using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1497)]
    [Attributes(9)]
    public sealed class C0Bc4Lna1Offset
    {
        public short Value { get; set; }
    }
}