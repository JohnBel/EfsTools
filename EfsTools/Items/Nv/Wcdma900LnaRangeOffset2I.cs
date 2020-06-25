using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(3659)]
    [Attributes(9)]
    public sealed class Wcdma900LnaRangeOffset2
    {
        public short Value { get; set; }
    }
}