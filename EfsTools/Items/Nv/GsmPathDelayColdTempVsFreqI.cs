using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4215)]
    [Attributes(9)]
    public sealed class GsmPathDelayColdTempVsFreq
    {
        [FieldCount(8)]
        public short[] Value { get; set; }
    }
}