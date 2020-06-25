using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(3642)]
    [Attributes(9)]
    public sealed class MfCoIm2IValue
    {
        public byte Value { get; set; }
    }
}