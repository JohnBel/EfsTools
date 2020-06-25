using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4466)]
    [Attributes(9)]
    public sealed class C1Wcdma900LnaRangeRise
    {
        public short Value { get; set; }
    }
}