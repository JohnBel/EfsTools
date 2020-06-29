using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5534)]
    [Attributes(9)]
    public sealed class Edge850PmeasG2F2
    {
        [FieldCount(32)]
        public ushort[] Value { get; set; }
    }
}