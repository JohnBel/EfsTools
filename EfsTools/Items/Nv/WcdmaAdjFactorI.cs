using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(541)]
    [Attributes(9)]
    public sealed class WcdmaAdjFactor
    {
        public byte Value { get; set; }
    }
}