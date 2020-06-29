using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5393)]
    [Attributes(9)]
    public sealed class Gsm1900EdgePaMidToHi
    {
        public ushort Value { get; set; }
    }
}