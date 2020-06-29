using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4218)]
    [Attributes(9)]
    public sealed class Gsm850PathDelayColdTempVsFreq
    {
        [FieldCount(8)]
        public short[] Value { get; set; }
    }
}