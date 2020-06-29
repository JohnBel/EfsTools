using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(666)]
    [Attributes(9)]
    public sealed class GpsDaccQaccum0
    {
        public byte Value { get; set; }
    }
}