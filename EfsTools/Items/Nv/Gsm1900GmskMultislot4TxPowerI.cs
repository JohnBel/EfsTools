using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4139)]
    [Attributes(9)]
    public sealed class Gsm1900GmskMultislot4TxPower
    {
        public short Value { get; set; }
    }
}