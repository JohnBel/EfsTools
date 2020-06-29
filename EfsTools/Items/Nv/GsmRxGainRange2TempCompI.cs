using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4378)]
    [Attributes(9)]
    public sealed class GsmRxGainRange2TempComp
    {
        [FieldCount(3)]
        public short[] Value { get; set; }
    }
}