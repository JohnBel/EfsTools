using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6666)]
    [Attributes(9)]
    public sealed class LteB40TimerHysterisis
    {
        public short Value { get; set; }
    }
}