using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1142)]
    [Attributes(9)]
    public sealed class Gsm850GainrangeSwitchpoints
    {
        [FieldCount(6)]
        public sbyte[] Value { get; set; }
    }
}