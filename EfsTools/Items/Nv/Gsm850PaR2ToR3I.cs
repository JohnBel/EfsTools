using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(5360)]
    [Attributes(9)]
    public sealed class Gsm850PaR2ToR3
    {
        public ushort Value { get; set; }
    }
}