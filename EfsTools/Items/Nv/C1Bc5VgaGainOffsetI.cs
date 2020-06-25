using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1452)]
    [Attributes(9)]
    public sealed class C1Bc5VgaGainOffset
    {
        public short Value { get; set; }
    }
}