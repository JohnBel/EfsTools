using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(434)]
    [Attributes(9)]
    public sealed class PcsTxLinMaster3
    {
        public short Value1 { get; set; }

        [FieldCount(37)]
        public byte[] Value2 { get; set; }
    }
}