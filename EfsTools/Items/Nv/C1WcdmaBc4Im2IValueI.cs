using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4513)]
    [Attributes(9)]
    public sealed class C1WcdmaBc4Im2IValue
    {
        public byte Value { get; set; }
    }
}