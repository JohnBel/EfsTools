using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1499)]
    [Attributes(9)]
    public sealed class C0Bc4Lna3Offset
    {
        public short Value { get; set; }
    }
}