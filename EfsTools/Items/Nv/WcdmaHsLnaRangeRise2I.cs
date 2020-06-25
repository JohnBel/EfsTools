using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4793)]
    [Attributes(9)]
    public sealed class WcdmaHsLnaRangeRise2
    {
        public short Value { get; set; }
    }
}