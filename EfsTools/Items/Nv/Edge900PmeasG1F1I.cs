using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5541)]
    [Attributes(9)]
    public sealed class Edge900PmeasG1F1
    {
        [FieldCount(32)]
        public ushort[] Value { get; set; }
    }
}