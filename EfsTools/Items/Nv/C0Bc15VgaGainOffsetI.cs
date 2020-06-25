using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4306)]
    [Attributes(9)]
    public sealed class C0Bc15VgaGainOffset
    {
        public short Value { get; set; }
    }
}