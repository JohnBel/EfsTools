using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4127)]
    [Attributes(9)]
    public sealed class Gsm850GmskMultislot4TxPower
    {
        public short Value { get; set; }
    }
}