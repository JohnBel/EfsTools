using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(859)]
    [Attributes(9)]
    public sealed class WcdmaLnaRangeRise2
    {
        public short Value { get; set; }
    }
}