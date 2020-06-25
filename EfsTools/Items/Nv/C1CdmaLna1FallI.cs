using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1041)]
    [Attributes(9)]
    public sealed class C1CdmaLna1Fall
    {
        public sbyte Value { get; set; }
    }
}