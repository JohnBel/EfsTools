using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5502)]
    [Attributes(9)]
    public sealed class Edge900RgiG2F3
    {
        [FieldCount(32)]
        public byte[] Value { get; set; }
    }
}