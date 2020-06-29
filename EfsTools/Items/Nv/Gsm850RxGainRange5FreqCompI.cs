using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3504)]
    [Attributes(9)]
    public sealed class Gsm850RxGainRange5FreqComp
    {
        [FieldCount(8)]
        public ushort[] Value { get; set; }
    }
}