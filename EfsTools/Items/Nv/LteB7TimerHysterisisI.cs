using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6561)]
    [Attributes(9)]
    public sealed class LteB7TimerHysterisis
    {
        public short Value { get; set; }
    }
}