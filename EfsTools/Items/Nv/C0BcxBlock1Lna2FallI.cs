using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6096)]
    [Attributes(9)]
    public sealed class C0BcxBlock1Lna2Fall
    {
        public sbyte Value { get; set; }
    }
}