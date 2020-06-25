using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1033)]
    [Attributes(9)]
    public sealed class C1CdmaLna1Rise
    {
        public sbyte Value { get; set; }
    }
}