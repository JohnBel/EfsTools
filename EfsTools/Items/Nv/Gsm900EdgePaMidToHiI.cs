using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(5386)]
    [Attributes(9)]
    public sealed class Gsm900EdgePaMidToHi
    {
        public ushort Value { get; set; }
    }
}