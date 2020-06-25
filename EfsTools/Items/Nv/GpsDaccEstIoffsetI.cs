using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(638)]
    [Attributes(9)]
    public sealed class GpsDaccEstIoffset
    {
        public uint Value { get; set; }
    }
}