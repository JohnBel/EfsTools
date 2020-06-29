using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(686)]
    [Attributes(9)]
    public sealed class GpsDaccGainMult
    {
        public byte Value { get; set; }
    }
}