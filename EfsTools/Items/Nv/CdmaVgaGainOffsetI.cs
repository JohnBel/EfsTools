using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(693)]
    [Attributes(9)]
    public sealed class CdmaVgaGainOffset
    {
        public short Value { get; set; }
    }
}