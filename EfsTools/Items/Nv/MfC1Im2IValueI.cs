using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(3645)]
    [Attributes(9)]
    public sealed class MfC1Im2IValue
    {
        public byte Value { get; set; }
    }
}