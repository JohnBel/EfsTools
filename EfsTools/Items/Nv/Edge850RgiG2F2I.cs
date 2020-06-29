using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5486)]
    [Attributes(9)]
    public sealed class Edge850RgiG2F2
    {
        [FieldCount(32)]
        public byte[] Value { get; set; }
    }
}