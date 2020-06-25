using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(3892)]
    [Attributes(9)]
    public sealed class C0Bc11Lna1Fall
    {
        public sbyte Value { get; set; }
    }
}