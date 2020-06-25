using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1891)]
    [Attributes(9)]
    public sealed class GsmTxBurstOffsetAdj
    {
        public short Value { get; set; }
    }
}