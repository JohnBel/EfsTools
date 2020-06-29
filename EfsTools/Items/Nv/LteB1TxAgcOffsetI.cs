using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6725)]
    [Attributes(9)]
    public sealed class LteB1TxAgcOffset
    {
        [FieldCount(16)]
        public short[] Value { get; set; }
    }
}