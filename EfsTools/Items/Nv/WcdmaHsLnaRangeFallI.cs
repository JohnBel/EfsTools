using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4790)]
    [Attributes(9)]
    public sealed class WcdmaHsLnaRangeFall
    {
        public short Value { get; set; }
    }
}