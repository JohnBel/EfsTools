using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4129)]
    [Attributes(9)]
    public sealed class GsmGmskMultislot2TxPower
    {
        public short Value { get; set; }
    }
}