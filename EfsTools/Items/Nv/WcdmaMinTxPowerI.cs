using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3440)]
    [Attributes(9)]
    public sealed class WcdmaMinTxPower
    {
        public short Value { get; set; }
    }
}