using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(2508)]
    [Attributes(9)]
    public sealed class EdgeFeatureSupport
    {
        public byte Value { get; set; }
    }
}