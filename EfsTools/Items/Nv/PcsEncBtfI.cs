using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(445)]
    [Attributes(9)]
    public sealed class PcsEncBtf
    {
        public uint Value { get; set; }
    }
}