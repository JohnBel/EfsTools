using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(7168)]
    [Attributes(9)]
    public sealed class WcdmaDc2LnaRangeOffsetCar1
    {
        public short Value { get; set; }
    }
}