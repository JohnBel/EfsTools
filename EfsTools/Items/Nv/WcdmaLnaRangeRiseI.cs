using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(519)]
    [Attributes(9)]
    public sealed class WcdmaLnaRangeRise
    {
        public short Value { get; set; }
    }
}