using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(144)]
    [Attributes(9)]
    public sealed class HdetSpn
    {
        public byte Value { get; set; }
    }
}