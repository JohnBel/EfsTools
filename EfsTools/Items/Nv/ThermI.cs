using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(141)]
    [Attributes(9)]
    public sealed class Therm
    {
        [FieldCount(2)]
        public byte[] Value { get; set; }
    }
}