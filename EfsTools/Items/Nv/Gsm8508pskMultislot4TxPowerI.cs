using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4143)]
    [Attributes(9)]
    public sealed class Gsm8508pskMultislot4TxPower
    {
        public short Value { get; set; }
    }
}