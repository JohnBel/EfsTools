using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5516)]
    [Attributes(9)]
    public sealed class Edge1900RgiG0F1
    {
        [FieldCount(32)]
        public byte[] Value { get; set; }
    }
}