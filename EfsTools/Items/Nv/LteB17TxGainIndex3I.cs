using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6629)]
    [Attributes(9)]
    public sealed class LteB17TxGainIndex3
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}