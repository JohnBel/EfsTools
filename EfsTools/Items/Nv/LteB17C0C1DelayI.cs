using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6636)]
    [Attributes(9)]
    public sealed class LteB17C0C1Delay
    {
        public sbyte Value { get; set; }
    }
}