using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(704)]
    [Attributes(9)]
    public sealed class FmMisCompBOffset
    {
        public int Value { get; set; }
    }
}