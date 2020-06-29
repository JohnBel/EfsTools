using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4156)]
    [Attributes(9)]
    public sealed class Gsm19008pskMultislot5TxPower
    {
        public short Value { get; set; }
    }
}