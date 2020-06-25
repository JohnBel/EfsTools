using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4325)]
    [Attributes(9)]
    public sealed class C1Bc15Lna3OffsetVsFreq
    {
        public sbyte[] Value { get; set; }
    }
}