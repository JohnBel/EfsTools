using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(838)]
    [Attributes(9)]
    public sealed class PcsIm2TransconductorValue
    {
        public byte Value { get; set; }
    }
}