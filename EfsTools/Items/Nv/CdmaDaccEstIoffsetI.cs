using System;
using EfsTools.Attributes;

using BinarySerialization;
namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(635)]
    [Attributes(9)]
    public sealed class CdmaDaccEstIoffset
    {
        public uint Value { get; set; }
    }
}