using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1047)]
    [Attributes(9)]
    public sealed class C1PcsLna3Fall
    {
        public sbyte Value { get; set; }
    }
}