using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3014)]
    [Attributes(9)]
    public sealed class WcdmaMaxTxPowerDchPc4
    {
        public ushort Value { get; set; }
    }
}