using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(690)]
    [Attributes(9)]
    public sealed class PcsIm2QValue
    {
        public byte Value { get; set; }
    }
}