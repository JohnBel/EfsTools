using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5368)]
    [Attributes(9)]
    public sealed class Gsm900PaPredistSwpt2
    {
        public ushort Value { get; set; }
    }
}