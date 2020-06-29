using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1100)]
    [Attributes(9)]
    public sealed class Gsm1900GainrangeSwitchpoints
    {
        [FieldCount(6)]
        public sbyte[] Value { get; set; }
    }
}