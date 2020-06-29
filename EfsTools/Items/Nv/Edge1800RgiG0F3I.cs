using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5512)]
    [Attributes(9)]
    public sealed class Edge1800RgiG0F3
    {
        [FieldCount(32)]
        public byte[] Value { get; set; }
    }
}