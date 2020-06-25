using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(866)]
    [Attributes(9)]
    public sealed class WcdmaLnaRangeOffset3
    {
        public short Value { get; set; }
    }
}