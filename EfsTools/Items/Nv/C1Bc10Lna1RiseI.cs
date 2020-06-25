using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(5257)]
    [Attributes(9)]
    public sealed class C1Bc10Lna1Rise
    {
        public sbyte Value { get; set; }
    }
}