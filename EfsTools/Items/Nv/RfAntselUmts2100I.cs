using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1956)]
    [Attributes(9)]
    public sealed class RfAntselUmts2100
    {
        [FieldCount(4)]
        public byte[] Value { get; set; }
    }
}