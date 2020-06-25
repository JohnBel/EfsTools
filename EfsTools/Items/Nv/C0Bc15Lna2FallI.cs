using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4312)]
    [Attributes(9)]
    public sealed class C0Bc15Lna2Fall
    {
        public sbyte Value { get; set; }
    }
}