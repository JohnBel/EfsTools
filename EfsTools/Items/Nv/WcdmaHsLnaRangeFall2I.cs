using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4789)]
    [Attributes(9)]
    public sealed class WcdmaHsLnaRangeFall2
    {
        public short Value { get; set; }
    }
}