using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5568)]
    [Attributes(9)]
    public sealed class Edge1900PmeasG0F2
    {
        [FieldCount(32)]
        public ushort[] Value { get; set; }
    }
}