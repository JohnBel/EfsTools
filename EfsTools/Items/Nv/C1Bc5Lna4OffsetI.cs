using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1449)]
    [Attributes(9)]
    public sealed class C1Bc5Lna4Offset
    {
        public short Value { get; set; }
    }
}