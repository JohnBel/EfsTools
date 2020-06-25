using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(5211)]
    [Attributes(9)]
    public sealed class C0Bc10Lna2Offset
    {
        public short Value { get; set; }
    }
}