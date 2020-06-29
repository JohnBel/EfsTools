using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4137)]
    [Attributes(9)]
    public sealed class Gsm1900GmskMultislot2TxPower
    {
        public short Value { get; set; }
    }
}