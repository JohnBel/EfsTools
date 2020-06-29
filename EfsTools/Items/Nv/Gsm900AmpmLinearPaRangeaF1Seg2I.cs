using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5662)]
    [Attributes(9)]
    public sealed class Gsm900AmpmLinearPaRangeaF1Seg2
    {
        [FieldCount(64)]
        public short[] Value { get; set; }
    }
}