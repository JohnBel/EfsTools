using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5574)]
    [Attributes(9)]
    public sealed class Edge1900PmeasG2F3
    {
        [FieldCount(32)]
        public ushort[] Value { get; set; }
    }
}