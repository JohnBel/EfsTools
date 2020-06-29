using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4144)]
    [Attributes(9)]
    public sealed class Gsm8508pskMultislot5TxPower
    {
        public short Value { get; set; }
    }
}