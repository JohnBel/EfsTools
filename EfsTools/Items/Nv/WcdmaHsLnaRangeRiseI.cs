using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4794)]
    [Attributes(9)]
    public sealed class WcdmaHsLnaRangeRise
    {
        public short Value { get; set; }
    }
}