using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(629)]
    [Attributes(9)]
    public sealed class FmRxfFgIoffset
    {
        public uint Value { get; set; }
    }
}