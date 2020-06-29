using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5498)]
    [Attributes(9)]
    public sealed class Edge900RgiG2F2
    {
        [FieldCount(32)]
        public byte[] Value { get; set; }
    }
}