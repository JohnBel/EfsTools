using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4132)]
    [Attributes(9)]
    public sealed class GsmGmskMultislot5TxPower
    {
        public short Value { get; set; }
    }
}