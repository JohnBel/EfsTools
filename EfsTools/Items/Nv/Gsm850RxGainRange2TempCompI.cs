using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4377)]
    [Attributes(9)]
    public sealed class Gsm850RxGainRange2TempComp
    {
        [FieldCount(3)]
        public short[] Value { get; set; }
    }
}