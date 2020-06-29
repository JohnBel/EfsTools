using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5656)]
    [Attributes(9)]
    public sealed class Gsm850AmpmLinearPaRangebF2Seg2
    {
        [FieldCount(64)]
        public short[] Value { get; set; }
    }
}