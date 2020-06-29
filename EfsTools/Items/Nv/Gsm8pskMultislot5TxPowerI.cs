using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4148)]
    [Attributes(9)]
    public sealed class Gsm8pskMultislot5TxPower
    {
        public short Value { get; set; }
    }
}