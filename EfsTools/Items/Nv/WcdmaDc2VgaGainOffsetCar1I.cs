using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(7178)]
    [Attributes(9)]
    public sealed class WcdmaDc2VgaGainOffsetCar1
    {
        public short Value { get; set; }
    }
}