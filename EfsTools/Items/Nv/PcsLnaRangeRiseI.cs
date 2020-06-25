using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(347)]
    [Attributes(9)]
    public sealed class PcsLnaRangeRise
    {
        public sbyte Value { get; set; }
    }
}