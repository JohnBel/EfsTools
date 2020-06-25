using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4611)]
    [Attributes(9)]
    public sealed class C1BcxBlockIm2QValue
    {
        public byte Value { get; set; }
    }
}