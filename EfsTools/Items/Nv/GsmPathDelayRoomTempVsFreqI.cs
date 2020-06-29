using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4216)]
    [Attributes(9)]
    public sealed class GsmPathDelayRoomTempVsFreq
    {
        [FieldCount(8)]
        public short[] Value { get; set; }
    }
}