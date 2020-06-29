using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(155)]
    [Attributes(9)]
    public sealed class PaRangeStepCal
    {
        public byte Value { get; set; }
    }
}