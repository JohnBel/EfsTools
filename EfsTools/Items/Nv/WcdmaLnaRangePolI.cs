using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(518)]
    [Attributes(9)]
    public sealed class WcdmaLnaRangePol
    {
        public byte Value { get; set; }
    }
}