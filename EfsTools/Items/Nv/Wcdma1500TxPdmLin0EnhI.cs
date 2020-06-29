using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(7025)]
    [Attributes(9)]
    public sealed class Wcdma1500TxPdmLin0Enh
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}