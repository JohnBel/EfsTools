using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(5478)]
    [Attributes(9)]
    public sealed class EdgeLinearTxGainParam
    {
        public ushort Value { get; set; }
    }
}