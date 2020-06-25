using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(865)]
    [Attributes(9)]
    public sealed class WcdmaLnaRangeOffset2
    {
        public short Value { get; set; }
    }
}