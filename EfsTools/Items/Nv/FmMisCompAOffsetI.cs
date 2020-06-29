using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(701)]
    [Attributes(9)]
    public sealed class FmMisCompAOffset
    {
        public int Value { get; set; }
    }
}