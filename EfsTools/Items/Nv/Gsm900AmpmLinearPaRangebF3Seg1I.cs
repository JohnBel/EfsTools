using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5671)]
    [Attributes(9)]
    public sealed class Gsm900AmpmLinearPaRangebF3Seg1
    {
        [FieldCount(64)]
        public short[] Value { get; set; }
    }
}