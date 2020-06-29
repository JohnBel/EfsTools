using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4128)]
    [Attributes(9)]
    public sealed class Gsm850GmskMultislot5TxPower
    {
        public short Value { get; set; }
    }
}