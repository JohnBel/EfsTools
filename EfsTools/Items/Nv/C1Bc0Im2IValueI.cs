using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1774)]
    [Attributes(9)]
    public sealed class C1Bc0Im2IValue
    {
        public byte Value { get; set; }
    }
}