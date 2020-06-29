using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1891)]
    [Attributes(9)]
    public sealed class GsmTxBurstOffsetAdj
    {
        public short Value { get; set; }
    }
}