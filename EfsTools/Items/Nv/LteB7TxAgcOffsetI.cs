using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6568)]
    [Attributes(9)]
    public sealed class LteB7TxAgcOffset
    {
        [FieldCount(16)]
        public short[] Value { get; set; }
    }
}