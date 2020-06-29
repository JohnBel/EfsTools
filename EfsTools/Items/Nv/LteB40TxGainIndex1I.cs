using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6679)]
    [Attributes(9)]
    public sealed class LteB40TxGainIndex1
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}