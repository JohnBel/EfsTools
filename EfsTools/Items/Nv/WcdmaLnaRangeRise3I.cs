using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(860)]
    [Attributes(9)]
    public sealed class WcdmaLnaRangeRise3
    {
        public short Value { get; set; }
    }
}