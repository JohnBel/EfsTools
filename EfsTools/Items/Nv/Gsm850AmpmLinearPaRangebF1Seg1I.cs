using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5651)]
    [Attributes(9)]
    public sealed class Gsm850AmpmLinearPaRangebF1Seg1
    {
        [FieldCount(64)]
        public short[] Value { get; set; }
    }
}