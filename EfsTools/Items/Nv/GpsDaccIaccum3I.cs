using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(658)]
    [Attributes(9)]
    public sealed class GpsDaccIaccum3
    {
        public byte Value { get; set; }
    }
}