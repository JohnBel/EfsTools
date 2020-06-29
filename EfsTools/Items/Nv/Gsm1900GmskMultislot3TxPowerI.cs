using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4138)]
    [Attributes(9)]
    public sealed class Gsm1900GmskMultislot3TxPower
    {
        public short Value { get; set; }
    }
}