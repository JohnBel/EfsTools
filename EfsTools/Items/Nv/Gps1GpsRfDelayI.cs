using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(443)]
    [Attributes(9)]
    public sealed class Gps1GpsRfDelay
    {
        public ushort Value { get; set; }
    }
}