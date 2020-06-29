using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(127)]
    [Attributes(9)]
    public sealed class CdmaRxLinOff0
    {
        public byte Value { get; set; }
    }
}