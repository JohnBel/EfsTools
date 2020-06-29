using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6476)]
    [Attributes(9)]
    public sealed class Edge1800LinearTxGainParam
    {
        public ushort Value { get; set; }
    }
}