using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5537)]
    [Attributes(9)]
    public sealed class Edge850PmeasG1F3
    {
        [FieldCount(32)]
        public ushort[] Value { get; set; }
    }
}