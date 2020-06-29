using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5519)]
    [Attributes(9)]
    public sealed class Edge1900RgiG3F1
    {
        [FieldCount(32)]
        public byte[] Value { get; set; }
    }
}