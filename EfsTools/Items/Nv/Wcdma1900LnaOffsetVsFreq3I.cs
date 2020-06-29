using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1155)]
    [Attributes(9)]
    public sealed class Wcdma1900LnaOffsetVsFreq3
    {
        [FieldCount(16)]
        public sbyte[] Value { get; set; }
    }
}