using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(706)]
    [Attributes(9)]
    public sealed class GpsMisCompBOffset
    {
        public int Value { get; set; }
    }
}