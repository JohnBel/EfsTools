using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4440)]
    [Attributes(9)]
    public sealed class C1Wcdma1800LnaRangeRise4
    {
        public short Value { get; set; }
    }
}