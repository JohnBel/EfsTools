using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(625)]
    [Attributes(9)]
    public sealed class FmRxfCgQoffset
    {
        public uint Value { get; set; }
    }
}