using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4130)]
    [Attributes(9)]
    public sealed class GsmGmskMultislot3TxPower
    {
        public short Value { get; set; }
    }
}