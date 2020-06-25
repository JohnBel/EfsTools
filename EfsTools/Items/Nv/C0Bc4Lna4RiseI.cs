using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1512)]
    [Attributes(9)]
    public sealed class C0Bc4Lna4Rise
    {
        public sbyte Value { get; set; }
    }
}