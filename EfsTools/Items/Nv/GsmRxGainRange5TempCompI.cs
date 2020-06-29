using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4390)]
    [Attributes(9)]
    public sealed class GsmRxGainRange5TempComp
    {
        [FieldCount(3)]
        public short[] Value { get; set; }
    }
}