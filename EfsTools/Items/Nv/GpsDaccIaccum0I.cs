using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(646)]
    [Attributes(9)]
    public sealed class GpsDaccIaccum0
    {
        public byte Value { get; set; }
    }
}