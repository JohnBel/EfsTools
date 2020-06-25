using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(3760)]
    [Attributes(9)]
    public sealed class C1Wcdma2100LnaRangeRise
    {
        public short Value { get; set; }
    }
}