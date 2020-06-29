using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3644)]
    [Attributes(9)]
    public sealed class MfCoIm2TransconductorValue
    {
        public byte Value { get; set; }
    }
}