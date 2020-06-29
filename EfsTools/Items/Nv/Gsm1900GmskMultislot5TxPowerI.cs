using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4140)]
    [Attributes(9)]
    public sealed class Gsm1900GmskMultislot5TxPower
    {
        public short Value { get; set; }
    }
}