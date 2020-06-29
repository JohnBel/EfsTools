using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(705)]
    [Attributes(9)]
    public sealed class DigitalMisCompBOffset
    {
        public int Value { get; set; }
    }
}