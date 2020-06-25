using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(2855)]
    [Attributes(9)]
    public sealed class Wcdma1800LnaRangeOffset3
    {
        public short Value { get; set; }
    }
}