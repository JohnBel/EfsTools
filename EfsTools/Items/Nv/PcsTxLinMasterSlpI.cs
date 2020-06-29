using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(330)]
    [Attributes(9)]
    public sealed class PcsTxLinMasterSlp
    {
        [FieldCount(37)]
        public byte[] Value { get; set; }
    }
}