using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4209)]
    [Attributes(9)]
    public sealed class EDtmFeatureSupport
    {
        public byte Value { get; set; }
    }
}