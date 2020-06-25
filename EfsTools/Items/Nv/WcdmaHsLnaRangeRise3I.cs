using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4792)]
    [Attributes(9)]
    public sealed class WcdmaHsLnaRangeRise3
    {
        public short Value { get; set; }
    }
}