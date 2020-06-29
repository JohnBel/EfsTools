using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(759)]
    [Attributes(9)]
    public sealed class GsmTxBurstRampDownIndex04
    {
        [FieldCount(30)]
        public ushort[] Value { get; set; }
    }
}