using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(3585)]
    [Attributes(9)]
    public sealed class C0Bc14ImLevel1
    {
        public byte Value { get; set; }
    }
}