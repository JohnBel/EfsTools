using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(630)]
    [Attributes(9)]
    public sealed class GpsRxfFgIoffset
    {
        public uint Value { get; set; }
    }
}