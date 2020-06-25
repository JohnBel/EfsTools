using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1594)]
    [Attributes(9)]
    public sealed class C0Bc3ImLevel2
    {
        public byte Value { get; set; }
    }
}