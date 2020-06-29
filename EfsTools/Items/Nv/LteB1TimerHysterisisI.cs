using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6718)]
    [Attributes(9)]
    public sealed class LteB1TimerHysterisis
    {
        public short Value { get; set; }
    }
}