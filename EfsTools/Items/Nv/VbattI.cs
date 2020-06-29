using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(90)]
    [Attributes(9)]
    public sealed class Vbatt
    {
        [FieldCount(2)]
        public byte[] Value { get; set; }
    }
}