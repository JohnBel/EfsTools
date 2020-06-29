using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(633)]
    [Attributes(9)]
    public sealed class FmRxfFgQoffset
    {
        public uint Value { get; set; }
    }
}