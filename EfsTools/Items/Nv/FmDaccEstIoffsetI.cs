using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(637)]
    [Attributes(9)]
    public sealed class FmDaccEstIoffset
    {
        public uint Value { get; set; }
    }
}