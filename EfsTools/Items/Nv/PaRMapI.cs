using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1875)]
    [Attributes(9)]
    public sealed class PaRMap
    {
        public byte Value { get; set; }
    }
}