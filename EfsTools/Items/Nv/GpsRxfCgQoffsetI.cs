using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(626)]
    [Attributes(9)]
    public sealed class GpsRxfCgQoffset
    {
        public uint Value { get; set; }
    }
}