using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5367)]
    [Attributes(9)]
    public sealed class Gsm900PaPredistSwpt1
    {
        public ushort Value { get; set; }
    }
}