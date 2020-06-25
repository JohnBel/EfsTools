using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6552)]
    [Attributes(9)]
    public sealed class LteB7EncBtf
    {
        public int Value { get; set; }
    }
}