using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6122)]
    [Attributes(9)]
    public sealed class C1BcxBlock1Lna2Rise
    {
        public sbyte Value { get; set; }
    }
}