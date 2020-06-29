using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4147)]
    [Attributes(9)]
    public sealed class Gsm8pskMultislot4TxPower
    {
        public short Value { get; set; }
    }
}