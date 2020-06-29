using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6274)]
    [Attributes(9)]
    public sealed class GpsDefaultTbf
    {
        public uint Value { get; set; }
    }
}