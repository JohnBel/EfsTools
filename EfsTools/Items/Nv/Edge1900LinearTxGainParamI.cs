using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6477)]
    [Attributes(9)]
    public sealed class Edge1900LinearTxGainParam
    {
        public ushort Value { get; set; }
    }
}