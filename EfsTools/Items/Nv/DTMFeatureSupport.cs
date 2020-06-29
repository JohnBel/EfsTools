using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3628)]
    [Attributes(9)]
    public sealed class DtmFeatureSupport
    {
        public byte Value { get; set; }
    }
}