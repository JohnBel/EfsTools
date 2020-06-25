using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(520)]
    [Attributes(9)]
    public sealed class WcdmaLnaRangeFall
    {
        public short Value { get; set; }
    }
}