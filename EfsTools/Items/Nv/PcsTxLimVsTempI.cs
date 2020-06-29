using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(332)]
    [Attributes(9)]
    public sealed class PcsTxLimVsTemp
    {
        [FieldCount(8)]
        public byte[] Value { get; set; }
    }
}