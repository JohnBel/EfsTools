using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(654)]
    [Attributes(9)]
    public sealed class GpsDaccIaccum2
    {
        public byte Value { get; set; }
    }
}