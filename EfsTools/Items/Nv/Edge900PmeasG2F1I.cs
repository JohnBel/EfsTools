using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5542)]
    [Attributes(9)]
    public sealed class Edge900PmeasG2F1
    {
        [FieldCount(32)]
        public ushort[] Value { get; set; }
    }
}