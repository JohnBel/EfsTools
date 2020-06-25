using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(496)]
    [Attributes(9)]
    public sealed class Ant2CdmaRxLinOff0
    {
        public byte Value { get; set; }
    }
}