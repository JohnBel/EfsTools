using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4570)]
    [Attributes(9)]
    public sealed class BcxBlockEncBtf
    {
        public uint Value { get; set; }
    }
}