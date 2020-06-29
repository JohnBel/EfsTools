using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(642)]
    [Attributes(9)]
    public sealed class GpsDaccEstQoffset
    {
        public uint Value { get; set; }
    }
}