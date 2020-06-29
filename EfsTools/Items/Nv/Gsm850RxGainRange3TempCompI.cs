using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4381)]
    [Attributes(9)]
    public sealed class Gsm850RxGainRange3TempComp
    {
        [FieldCount(3)]
        public short[] Value { get; set; }
    }
}