using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(688)]
    [Attributes(9)]
    public sealed class PcsIm2IValue
    {
        public byte Value { get; set; }
    }
}