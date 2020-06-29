using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4141)]
    [Attributes(9)]
    public sealed class Gsm8508pskMultislot2TxPower
    {
        public short Value { get; set; }
    }
}