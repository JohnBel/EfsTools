using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(5359)]
    [Attributes(9)]
    public sealed class Gsm850PaR1ToR2
    {
        public ushort Value { get; set; }
    }
}