using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(623)]
    [Attributes(9)]
    public sealed class CdmaRxfCgQoffset
    {
        public uint Value { get; set; }
    }
}