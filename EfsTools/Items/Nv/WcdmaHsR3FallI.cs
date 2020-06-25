using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2729)]
    [Attributes(9)]
    public sealed class WcdmaHsR3Fall
    {
        public short Value { get; set; }
    }
}