using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4126)]
    [Attributes(9)]
    public sealed class Gsm850GmskMultislot3TxPower
    {
        public short Value { get; set; }
    }
}