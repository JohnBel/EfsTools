using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4134)]
    [Attributes(9)]
    public sealed class DcsGmskMultislot3TxPower
    {
        public short Value { get; set; }
    }
}