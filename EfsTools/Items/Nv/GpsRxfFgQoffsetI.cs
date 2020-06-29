using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(634)]
    [Attributes(9)]
    public sealed class GpsRxfFgQoffset
    {
        public uint Value { get; set; }
    }
}