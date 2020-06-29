using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6710)]
    [Attributes(9)]
    public sealed class LteB1MaxTxPower
    {
        public sbyte Value { get; set; }
    }
}