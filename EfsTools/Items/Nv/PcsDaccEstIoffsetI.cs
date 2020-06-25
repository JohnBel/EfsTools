using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(636)]
    [Attributes(9)]
    public sealed class PcsDaccEstIoffset
    {
        public uint Value { get; set; }
    }
}