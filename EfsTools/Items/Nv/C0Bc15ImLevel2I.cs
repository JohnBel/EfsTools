using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4318)]
    [Attributes(9)]
    public sealed class C0Bc15ImLevel2
    {
        public byte Value { get; set; }
    }
}