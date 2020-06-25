using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(856)]
    [Attributes(9)]
    public sealed class WcdmaVgaGainOffset
    {
        public short Value { get; set; }
    }
}