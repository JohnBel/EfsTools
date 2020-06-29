using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6826)]
    [Attributes(9)]
    public sealed class LteB40TxCarrierFeedthroughComp
    {
        [FieldCount(2)]
        public short[] Value { get; set; }
    }
}