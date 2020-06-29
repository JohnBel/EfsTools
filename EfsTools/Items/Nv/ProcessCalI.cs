using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(5432)]
    [Attributes(9)]
    public sealed class ProcessCal
    {
        public ushort Value1 { get; set; }

        [FieldCount(3)]
        public byte[] Value2 { get; set; }
    }
}