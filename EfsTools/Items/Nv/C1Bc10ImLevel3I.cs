using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(5267)]
    [Attributes(9)]
    public sealed class C1Bc10ImLevel3
    {
        public byte Value { get; set; }
    }
}