using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4404)]
    [Attributes(9)]
    public sealed class WcdmaLnaRangeRise4
    {
        public short Value { get; set; }
    }
}