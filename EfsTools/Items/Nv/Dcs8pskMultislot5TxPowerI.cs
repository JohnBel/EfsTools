using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4152)]
    [Attributes(9)]
    public sealed class Dcs8pskMultislot5TxPower
    {
        public short Value { get; set; }
    }
}