using System;
using System.Runtime.InteropServices;
using BinarySerialization;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(505)]
    [Attributes(9)]
    public sealed class Ant2PcsRxLinOff0
    {
        public byte Value { get; set; }
    }
}