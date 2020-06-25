using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(7177)]
    [Attributes(9)]
    public sealed class WcdmaDc1VgaGainOffsetCar1
    {
        public short Value { get; set; }
    }
}