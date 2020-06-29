using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4220)]
    [Attributes(9)]
    public sealed class Gsm850PathDelayHotTempVsFreq
    {
        [FieldCount(8)]
        public short[] Value { get; set; }
    }
}