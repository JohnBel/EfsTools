using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4146)]
    [Attributes(9)]
    public sealed class Gsm8pskMultislot3TxPower
    {
        public short Value { get; set; }
    }
}