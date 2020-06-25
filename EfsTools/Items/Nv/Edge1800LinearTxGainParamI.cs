using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6476)]
    [Attributes(9)]
    public sealed class Edge1800LinearTxGainParam
    {
        public ushort Value { get; set; }
    }
}