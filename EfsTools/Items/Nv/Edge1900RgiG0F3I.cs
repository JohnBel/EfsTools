using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5524)]
    [Attributes(9)]
    public sealed class Edge1900RgiG0F3
    {
        [FieldCount(32)]
        public byte[] Value { get; set; }
    }
}