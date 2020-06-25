using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(7075)]
    [Attributes(9)]
    public sealed class C1Wcdma1500LnaRangeFall2
    {
        public short Value { get; set; }
    }
}