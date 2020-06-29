using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(650)]
    [Attributes(9)]
    public sealed class GpsDaccIaccum1
    {
        public byte Value { get; set; }
    }
}