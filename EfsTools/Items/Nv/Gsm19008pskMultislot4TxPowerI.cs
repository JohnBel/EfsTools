using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4155)]
    [Attributes(9)]
    public sealed class Gsm19008pskMultislot4TxPower
    {
        public short Value { get; set; }
    }
}