using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(622)]
    [Attributes(9)]
    public sealed class GpsRxfCgIoffset
    {
        public uint Value { get; set; }
    }
}