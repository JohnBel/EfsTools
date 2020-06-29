using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4219)]
    [Attributes(9)]
    public sealed class Gsm850PathDelayRoomTempVsFreq
    {
        [FieldCount(8)]
        public short[] Value { get; set; }
    }
}