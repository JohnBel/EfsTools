using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(3925)]
    [Attributes(9)]
    public sealed class C1Bc11Lna4Fall
    {
        public sbyte Value { get; set; }
    }
}