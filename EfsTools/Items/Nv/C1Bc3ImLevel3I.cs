using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1622)]
    [Attributes(9)]
    public sealed class C1Bc3ImLevel3
    {
        public byte Value { get; set; }
    }
}