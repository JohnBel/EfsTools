using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(682)]
    [Attributes(9)]
    public sealed class GpsDaccQaccum4
    {
        public byte Value { get; set; }
    }
}