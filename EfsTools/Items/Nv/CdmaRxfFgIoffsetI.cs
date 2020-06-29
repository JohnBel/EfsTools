using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(627)]
    [Attributes(9)]
    public sealed class CdmaRxfFgIoffset
    {
        public uint Value { get; set; }
    }
}