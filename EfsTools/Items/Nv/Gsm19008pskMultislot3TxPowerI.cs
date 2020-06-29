using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4154)]
    [Attributes(9)]
    public sealed class Gsm19008pskMultislot3TxPower
    {
        public short Value { get; set; }
    }
}