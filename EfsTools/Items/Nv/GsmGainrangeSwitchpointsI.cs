using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(916)]
    [Attributes(9)]
    public sealed class GsmGainrangeSwitchpoints
    {
        [FieldCount(6)]
        public sbyte[] Value { get; set; }
    }
}