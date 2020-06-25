using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(862)]
    [Attributes(9)]
    public sealed class WcdmaLnaRangeFall3
    {
        public short Value { get; set; }
    }
}