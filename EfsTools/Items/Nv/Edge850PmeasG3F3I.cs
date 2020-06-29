using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(5539)]
    [Attributes(9)]
    public sealed class Edge850PmeasG3F3
    {
        [FieldCount(32)]
        public ushort[] Value { get; set; }
    }
}