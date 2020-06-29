using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(7004)]
    [Attributes(9)]
    public sealed class Wcdma1500TxPdmLin0
    {
        [FieldCount(32)]
        public ushort[] Value { get; set; }
    }
}