using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(876)]
    [Attributes(9)]
    public sealed class WcdmaMaxTxPower
    {
        public sbyte Value { get; set; }
    }
}