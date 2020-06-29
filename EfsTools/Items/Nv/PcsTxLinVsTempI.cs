using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(331)]
    [Attributes(9)]
    public sealed class PcsTxLinVsTemp
    {
        [FieldCount(8)]
        public byte[] Value { get; set; }
    }
}