using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6709)]
    [Attributes(9)]
    public sealed class LteB1EncBtf
    {
        public int Value { get; set; }
    }
}