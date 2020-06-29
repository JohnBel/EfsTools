using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5511)]
    [Attributes(9)]
    public sealed class Edge1800RgiG3F2
    {
        [FieldCount(32)]
        public byte[] Value { get; set; }
    }
}