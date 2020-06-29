using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(496)]
    [Attributes(9)]
    public sealed class Ant2CdmaRxLinOff0
    {
        public byte Value { get; set; }
    }
}