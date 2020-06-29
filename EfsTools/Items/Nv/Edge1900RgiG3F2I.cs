using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5523)]
    [Attributes(9)]
    public sealed class Edge1900RgiG3F2
    {
        [FieldCount(32)]
        public byte[] Value { get; set; }
    }
}