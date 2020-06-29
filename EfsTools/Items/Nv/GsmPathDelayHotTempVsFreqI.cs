using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4217)]
    [Attributes(9)]
    public sealed class GsmPathDelayHotTempVsFreq
    {
        [FieldCount(8)]
        public short[] Value { get; set; }
    }
}