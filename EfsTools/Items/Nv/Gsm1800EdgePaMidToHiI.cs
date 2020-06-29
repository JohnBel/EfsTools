using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5391)]
    [Attributes(9)]
    public sealed class Gsm1800EdgePaMidToHi
    {
        public ushort Value { get; set; }
    }
}