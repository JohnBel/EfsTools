using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5658)]
    [Attributes(9)]
    public sealed class Gsm850AmpmLinearPaRangeaF3Seg2
    {
        [FieldCount(64)]
        public short[] Value { get; set; }
    }
}