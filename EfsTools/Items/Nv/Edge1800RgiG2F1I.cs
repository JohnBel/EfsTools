using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5506)]
    [Attributes(9)]
    public sealed class Edge1800RgiG2F1
    {
        [FieldCount(32)]
        public byte[] Value { get; set; }
    }
}