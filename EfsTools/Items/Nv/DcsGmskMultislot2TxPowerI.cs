using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4133)]
    [Attributes(9)]
    public sealed class DcsGmskMultislot2TxPower
    {
        public short Value { get; set; }
    }
}