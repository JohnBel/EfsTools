using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(662)]
    [Attributes(9)]
    public sealed class GpsDaccIaccum4
    {
        public byte Value { get; set; }
    }
}