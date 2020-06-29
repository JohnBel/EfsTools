using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4131)]
    [Attributes(9)]
    public sealed class GsmGmskMultislot4TxPower
    {
        public short Value { get; set; }
    }
}