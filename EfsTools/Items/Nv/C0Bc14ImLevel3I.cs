using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(3587)]
    [Attributes(9)]
    public sealed class C0Bc14ImLevel3
    {
        public byte Value { get; set; }
    }
}