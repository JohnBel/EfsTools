using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4374)]
    [Attributes(9)]
    public sealed class GsmRxGainRange1TempComp
    {
        [FieldCount(3)]
        public short[] Value { get; set; }
    }
}