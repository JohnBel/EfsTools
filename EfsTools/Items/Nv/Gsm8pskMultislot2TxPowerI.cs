using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4145)]
    [Attributes(9)]
    public sealed class Gsm8pskMultislot2TxPower
    {
        public short Value { get; set; }
    }
}