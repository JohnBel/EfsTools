using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(5389)]
    [Attributes(9)]
    public sealed class Gsm850EdgePaMidToHi
    {
        public ushort Value { get; set; }
    }
}