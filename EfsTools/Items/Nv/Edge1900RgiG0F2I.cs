using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5520)]
    [Attributes(9)]
    public sealed class Edge1900RgiG0F2
    {
        [FieldCount(32)]
        public byte[] Value { get; set; }
    }
}