using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4403)]
    [Attributes(9)]
    public sealed class WcdmaLnaRangeOffset4
    {
        public short Value { get; set; }
    }
}