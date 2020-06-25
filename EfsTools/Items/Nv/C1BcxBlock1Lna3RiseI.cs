using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6124)]
    [Attributes(9)]
    public sealed class C1BcxBlock1Lna3Rise
    {
        public sbyte Value { get; set; }
    }
}