using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5497)]
    [Attributes(9)]
    public sealed class Edge900RgiG1F2
    {
        [FieldCount(32)]
        public byte[] Value { get; set; }
    }
}