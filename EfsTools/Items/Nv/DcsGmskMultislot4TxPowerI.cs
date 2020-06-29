using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4135)]
    [Attributes(9)]
    public sealed class DcsGmskMultislot4TxPower
    {
        public short Value { get; set; }
    }
}