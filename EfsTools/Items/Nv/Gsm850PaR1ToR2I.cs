using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5359)]
    [Attributes(9)]
    public sealed class Gsm850PaR1ToR2
    {
        public ushort Value { get; set; }
    }
}