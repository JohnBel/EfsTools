using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(631)]
    [Attributes(9)]
    public sealed class CdmaRxfFgQoffset
    {
        public uint Value { get; set; }
    }
}