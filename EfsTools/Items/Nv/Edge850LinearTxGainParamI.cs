using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6475)]
    [Attributes(9)]
    public sealed class Edge850LinearTxGainParam
    {
        public ushort Value { get; set; }
    }
}