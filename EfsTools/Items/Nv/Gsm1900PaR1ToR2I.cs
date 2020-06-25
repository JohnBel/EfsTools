using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(5357)]
    [Attributes(9)]
    public sealed class Gsm1900PaR1ToR2
    {
        public ushort Value { get; set; }
    }
}