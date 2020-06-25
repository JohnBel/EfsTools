using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(5180)]
    [Attributes(9)]
    public sealed class Bc10HdetOff
    {
        public byte Value { get; set; }
    }
}