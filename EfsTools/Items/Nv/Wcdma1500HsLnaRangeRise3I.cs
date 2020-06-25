using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(7058)]
    [Attributes(9)]
    public sealed class Wcdma1500HsLnaRangeRise3
    {
        public short Value { get; set; }
    }
}