using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4136)]
    [Attributes(9)]
    public sealed class DcsGmskMultislot5TxPower
    {
        public short Value { get; set; }
    }
}