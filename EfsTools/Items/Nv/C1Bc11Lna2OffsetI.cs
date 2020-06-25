using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(3910)]
    [Attributes(9)]
    public sealed class C1Bc11Lna2Offset
    {
        public short Value { get; set; }
    }
}