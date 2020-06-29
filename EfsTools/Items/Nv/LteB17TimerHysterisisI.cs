using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6614)]
    [Attributes(9)]
    public sealed class LteB17TimerHysterisis
    {
        public short Value { get; set; }
    }
}