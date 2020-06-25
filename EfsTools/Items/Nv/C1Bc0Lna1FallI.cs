using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1780)]
    [Attributes(9)]
    public sealed class C1Bc0Lna1Fall
    {
        public sbyte Value { get; set; }
    }
}