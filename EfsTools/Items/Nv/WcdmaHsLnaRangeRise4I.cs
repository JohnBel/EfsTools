using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4791)]
    [Attributes(9)]
    public sealed class WcdmaHsLnaRangeRise4
    {
        public short Value { get; set; }
    }
}