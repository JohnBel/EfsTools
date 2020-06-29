using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5552)]
    [Attributes(9)]
    public sealed class Edge1800PmeasG0F1
    {
        [FieldCount(32)]
        public ushort[] Value { get; set; }
    }
}