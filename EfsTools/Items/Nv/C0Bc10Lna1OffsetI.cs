using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(5210)]
    [Attributes(9)]
    public sealed class C0Bc10Lna1Offset
    {
        public short Value { get; set; }
    }
}