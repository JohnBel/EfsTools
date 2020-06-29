using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1032)]
    [Attributes(9)]
    public sealed class GpsRfConfig
    {
        public byte Value { get; set; }
    }
}