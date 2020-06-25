using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4437)]
    [Attributes(9)]
    public sealed class C1Wcdma1800LnaRangeRise
    {
        public short Value { get; set; }
    }
}