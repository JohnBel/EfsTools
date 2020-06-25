using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1655)]
    [Attributes(9)]
    public sealed class C0Bc1Lna2Offset
    {
        public short Value { get; set; }
    }
}