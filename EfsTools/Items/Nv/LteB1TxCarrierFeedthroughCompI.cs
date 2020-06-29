using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6827)]
    [Attributes(9)]
    public sealed class LteB1TxCarrierFeedthroughComp
    {
        [FieldCount(2)]
        public short[] Value { get; set; }
    }
}