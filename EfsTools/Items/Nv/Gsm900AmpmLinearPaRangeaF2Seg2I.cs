using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5666)]
    [Attributes(9)]
    public sealed class Gsm900AmpmLinearPaRangeaF2Seg2
    {
        [FieldCount(64)]
        public short[] Value { get; set; }
    }
}