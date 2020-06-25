using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(3556)]
    [Attributes(9)]
    public sealed class Bc14EncBtf
    {
        public uint Value { get; set; }
    }
}