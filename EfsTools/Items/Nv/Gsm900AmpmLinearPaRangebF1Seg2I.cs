using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5664)]
    [Attributes(9)]
    public sealed class Gsm900AmpmLinearPaRangebF1Seg2
    {
        [FieldCount(64)]
        public short[] Value { get; set; }
    }
}