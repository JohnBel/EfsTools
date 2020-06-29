using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5670)]
    [Attributes(9)]
    public sealed class Gsm900AmpmLinearPaRangeaF3Seg2
    {
        [FieldCount(64)]
        public short[] Value { get; set; }
    }
}