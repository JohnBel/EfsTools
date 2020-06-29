using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5548)]
    [Attributes(9)]
    public sealed class Edge900PmeasG0F3
    {
        [FieldCount(32)]
        public ushort[] Value { get; set; }
    }
}