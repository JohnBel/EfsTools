using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(3870)]
    [Attributes(9)]
    public sealed class Bc11HdetOff
    {
        public byte Value { get; set; }
    }
}