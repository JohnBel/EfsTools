using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(703)]
    [Attributes(9)]
    public sealed class GpsMisCompAOffset
    {
        public int Value { get; set; }
    }
}