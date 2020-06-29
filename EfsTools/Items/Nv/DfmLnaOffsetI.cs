using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(607)]
    [Attributes(9)]
    public sealed class DfmLnaOffset
    {
        public short Value { get; set; }
    }
}