using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(3595)]
    [Attributes(9)]
    public sealed class C1Bc14Lna1Offset
    {
        public short Value { get; set; }
    }
}