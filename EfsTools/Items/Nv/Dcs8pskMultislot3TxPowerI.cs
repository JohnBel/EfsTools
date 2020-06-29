using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4150)]
    [Attributes(9)]
    public sealed class Dcs8pskMultislot3TxPower
    {
        public short Value { get; set; }
    }
}