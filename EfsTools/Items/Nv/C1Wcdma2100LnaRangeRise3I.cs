using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(3770)]
    [Attributes(9)]
    public sealed class C1Wcdma2100LnaRangeRise3
    {
        public short Value { get; set; }
    }
}