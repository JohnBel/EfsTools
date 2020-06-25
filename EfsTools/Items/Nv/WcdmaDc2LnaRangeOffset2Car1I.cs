using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(7170)]
    [Attributes(9)]
    public sealed class WcdmaDc2LnaRangeOffset2Car1
    {
        public short Value { get; set; }
    }
}