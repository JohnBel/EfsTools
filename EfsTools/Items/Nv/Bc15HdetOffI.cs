using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4285)]
    [Attributes(9)]
    public sealed class Bc15HdetOff
    {
        public byte Value { get; set; }
    }
}