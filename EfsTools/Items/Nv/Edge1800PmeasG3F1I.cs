using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5555)]
    [Attributes(9)]
    public sealed class Edge1800PmeasG3F1
    {
        [FieldCount(32)]
        public ushort[] Value { get; set; }
    }
}