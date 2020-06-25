using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1564)]
    [Attributes(9)]
    public sealed class Bc3HdetOff
    {
        public byte Value { get; set; }
    }
}