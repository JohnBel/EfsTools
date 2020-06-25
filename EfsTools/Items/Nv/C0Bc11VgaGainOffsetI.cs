using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(3888)]
    [Attributes(9)]
    public sealed class C0Bc11VgaGainOffset
    {
        public short Value { get; set; }
    }
}