using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(3909)]
    [Attributes(9)]
    public sealed class C1Bc11Lna1Offset
    {
        public short Value { get; set; }
    }
}