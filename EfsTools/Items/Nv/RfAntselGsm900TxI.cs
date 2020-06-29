using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1948)]
    [Attributes(9)]
    public sealed class RfAntselGsm900Tx
    {
        [FieldCount(4)]
        public byte[] Value { get; set; }
    }
}