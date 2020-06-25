using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(3581)]
    [Attributes(9)]
    public sealed class C0Bc14Lna3Rise
    {
        public sbyte Value { get; set; }
    }
}