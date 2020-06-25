using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4788)]
    [Attributes(9)]
    public sealed class WcdmaHsLnaRangeFall3
    {
        public short Value { get; set; }
    }
}