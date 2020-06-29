using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6510)]
    [Attributes(9)]
    public sealed class LteB13TimerHysterisis
    {
        public short Value { get; set; }
    }
}