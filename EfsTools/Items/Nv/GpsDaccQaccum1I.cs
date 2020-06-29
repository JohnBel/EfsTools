using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(670)]
    [Attributes(9)]
    public sealed class GpsDaccQaccum1
    {
        public byte Value { get; set; }
    }
}