using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5665)]
    [Attributes(9)]
    public sealed class Gsm900AmpmLinearPaRangeaF2Seg1
    {
        [FieldCount(64)]
        public short[] Value { get; set; }
    }
}