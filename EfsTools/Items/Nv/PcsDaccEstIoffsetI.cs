using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(636)]
    [Attributes(9)]
    public sealed class PcsDaccEstIoffset
    {
        public uint Value { get; set; }
    }
}