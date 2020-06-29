using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5365)]
    [Attributes(9)]
    public sealed class Gsm850PaPredistSwpt1
    {
        public ushort Value { get; set; }
    }
}