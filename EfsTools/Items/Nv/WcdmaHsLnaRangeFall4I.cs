using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4787)]
    [Attributes(9)]
    public sealed class WcdmaHsLnaRangeFall4
    {
        public short Value { get; set; }
    }
}