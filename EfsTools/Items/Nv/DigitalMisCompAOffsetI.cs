using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(702)]
    [Attributes(9)]
    public sealed class DigitalMisCompAOffset
    {
        public int Value { get; set; }
    }
}