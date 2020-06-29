using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5480)]
    [Attributes(9)]
    public sealed class Edge850RgiG0F1
    {
        [FieldCount(32)]
        public byte[] Value { get; set; }
    }
}