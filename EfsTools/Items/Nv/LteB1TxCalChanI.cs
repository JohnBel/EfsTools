using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6720)]
    [Attributes(9)]
    public sealed class LteB1TxCalChan
    {
        [FieldCount(16)]
        public ushort[] Value { get; set; }
    }
}