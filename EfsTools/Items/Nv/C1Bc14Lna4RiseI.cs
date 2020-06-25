using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(3610)]
    [Attributes(9)]
    public sealed class C1Bc14Lna4Rise
    {
        public sbyte Value { get; set; }
    }
}