using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4125)]
    [Attributes(9)]
    public sealed class Gsm850GmskMultislot2TxPower
    {
        public short Value { get; set; }
    }
}