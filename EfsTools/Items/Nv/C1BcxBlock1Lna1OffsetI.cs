using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6111)]
    [Attributes(9)]
    public sealed class C1BcxBlock1Lna1Offset
    {
        public short Value { get; set; }
    }
}