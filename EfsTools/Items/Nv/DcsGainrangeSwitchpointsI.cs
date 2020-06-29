using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(917)]
    [Attributes(9)]
    public sealed class DcsGainrangeSwitchpoints
    {
        [FieldCount(6)]
        public sbyte[] Value { get; set; }
    }
}