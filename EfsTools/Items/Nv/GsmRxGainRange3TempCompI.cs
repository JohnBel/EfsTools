using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4382)]
    [Attributes(9)]
    public sealed class GsmRxGainRange3TempComp
    {
        [FieldCount(3)]
        public short[] Value { get; set; }
    }
}