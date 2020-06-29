using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6673)]
    [Attributes(9)]
    public sealed class LteB40TxAgcOffset
    {
        [FieldCount(16)]
        public short[] Value { get; set; }
    }
}