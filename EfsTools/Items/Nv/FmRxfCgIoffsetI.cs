using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(621)]
    [Attributes(9)]
    public sealed class FmRxfCgIoffset
    {
        public uint Value { get; set; }
    }
}