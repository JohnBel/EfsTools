using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(5355)]
    [Attributes(9)]
    public sealed class Gsm1800PaR1ToR2
    {
        public ushort Value { get; set; }
    }
}