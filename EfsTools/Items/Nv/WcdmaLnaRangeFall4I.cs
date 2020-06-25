using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4402)]
    [Attributes(9)]
    public sealed class WcdmaLnaRangeFall4
    {
        public short Value { get; set; }
    }
}