using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1105)]
    [Attributes(9)]
    public sealed class Gsm850RxGainRange4FreqComp
    {
        [FieldCount(8)]
        public short[] Value { get; set; }
    }
}