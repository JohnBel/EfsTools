using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5505)]
    [Attributes(9)]
    public sealed class Edge1800RgiG1F1
    {
        [FieldCount(32)]
        public byte[] Value { get; set; }
    }
}