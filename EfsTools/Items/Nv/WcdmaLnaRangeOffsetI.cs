using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(524)]
    [Attributes(9)]
    public sealed class WcdmaLnaRangeOffset
    {
        public short Value { get; set; }
    }
}