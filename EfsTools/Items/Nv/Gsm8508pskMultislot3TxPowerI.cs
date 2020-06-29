using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4142)]
    [Attributes(9)]
    public sealed class Gsm8508pskMultislot3TxPower
    {
        public short Value { get; set; }
    }
}