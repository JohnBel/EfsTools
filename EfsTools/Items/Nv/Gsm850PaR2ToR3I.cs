using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5360)]
    [Attributes(9)]
    public sealed class Gsm850PaR2ToR3
    {
        public ushort Value { get; set; }
    }
}