using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1669)]
    [Attributes(9)]
    public sealed class C0Bc1Im2QValue
    {
        public byte Value { get; set; }
    }
}