using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1381)]
    [Attributes(9)]
    public sealed class C1Bc6Lna3Rise
    {
        public sbyte Value { get; set; }
    }
}