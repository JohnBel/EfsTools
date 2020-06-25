using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(974)]
    [Attributes(9)]
    public sealed class C1CdmaVgaGainOffset
    {
        public short Value { get; set; }
    }
}