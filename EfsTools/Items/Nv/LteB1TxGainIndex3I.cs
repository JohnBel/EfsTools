using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6733)]
    [Attributes(9)]
    public sealed class LteB1TxGainIndex3
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}