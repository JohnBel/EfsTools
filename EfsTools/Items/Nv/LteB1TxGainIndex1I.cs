using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6731)]
    [Attributes(9)]
    public sealed class LteB1TxGainIndex1
    {
        [FieldCount(64)]
        public ushort[] Value { get; set; }
    }
}