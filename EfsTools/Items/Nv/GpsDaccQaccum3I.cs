using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(678)]
    [Attributes(9)]
    public sealed class GpsDaccQaccum3
    {
        public byte Value { get; set; }
    }
}