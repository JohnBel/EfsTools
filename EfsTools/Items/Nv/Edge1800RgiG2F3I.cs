using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5514)]
    [Attributes(9)]
    public sealed class Edge1800RgiG2F3
    {
        [FieldCount(32)]
        public byte[] Value { get; set; }
    }
}