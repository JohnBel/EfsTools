using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1464)]
    [Attributes(9)]
    public sealed class C1Bc5ImLevel2
    {
        public byte Value { get; set; }
    }
}