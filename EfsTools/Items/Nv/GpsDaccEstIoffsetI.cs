using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(638)]
    [Attributes(9)]
    public sealed class GpsDaccEstIoffset
    {
        public uint Value { get; set; }
    }
}