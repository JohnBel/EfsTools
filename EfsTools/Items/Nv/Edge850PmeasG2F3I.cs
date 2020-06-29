using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5538)]
    [Attributes(9)]
    public sealed class Edge850PmeasG2F3
    {
        [FieldCount(32)]
        public ushort[] Value { get; set; }
    }
}