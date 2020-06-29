using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6273)]
    [Attributes(9)]
    public sealed class GpsDefaultOperatingMode
    {
        public uint Value { get; set; }
    }
}