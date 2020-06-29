using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(884)]
    [Attributes(9)]
    public sealed class TxWarmup
    {
        public ushort Value { get; set; }
    }
}