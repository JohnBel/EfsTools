using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(692)]
    [Attributes(9)]
    public sealed class FmVgaGainOffset
    {
        public short Value { get; set; }
    }
}