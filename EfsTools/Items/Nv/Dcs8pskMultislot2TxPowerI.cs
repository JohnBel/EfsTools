using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4149)]
    [Attributes(9)]
    public sealed class Dcs8pskMultislot2TxPower
    {
        public short Value { get; set; }
    }
}