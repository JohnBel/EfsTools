using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5362)]
    [Attributes(9)]
    public sealed class Gsm900PaR1ToR2
    {
        public ushort Value { get; set; }
    }
}