using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5364)]
    [Attributes(9)]
    public sealed class Gsm900PaR3ToR4
    {
        public ushort Value { get; set; }
    }
}