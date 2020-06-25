using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(5361)]
    [Attributes(9)]
    public sealed class Gsm850PaR3ToR4
    {
        public ushort Value { get; set; }
    }
}