using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4151)]
    [Attributes(9)]
    public sealed class Dcs8pskMultislot4TxPower
    {
        public short Value { get; set; }
    }
}