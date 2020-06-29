using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(449)]
    [Attributes(9)]
    public sealed class Gps1GpsRfLoss
    {
        public byte Value { get; set; }
    }
}