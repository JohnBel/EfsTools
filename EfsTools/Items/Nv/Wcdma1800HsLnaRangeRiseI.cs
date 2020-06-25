using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4750)]
    [Attributes(9)]
    public sealed class Wcdma1800HsLnaRangeRise
    {
        public short Value { get; set; }
    }
}