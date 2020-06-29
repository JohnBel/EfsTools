using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3630)]
    [Attributes(9)]
    public sealed class EdaFeatureSupport
    {
        public byte Value { get; set; }
    }
}