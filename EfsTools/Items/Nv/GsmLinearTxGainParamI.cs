using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(5477)]
    [Attributes(9)]
    public sealed class GsmLinearTxGainParam
    {
        public ushort Value { get; set; }
    }
}