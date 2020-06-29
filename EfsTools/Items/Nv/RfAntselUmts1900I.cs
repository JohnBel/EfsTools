using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1955)]
    [Attributes(9)]
    public sealed class RfAntselUmts1900
    {
        [FieldCount(4)]
        public byte[] Value { get; set; }
    }
}