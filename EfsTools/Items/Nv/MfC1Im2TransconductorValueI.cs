using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3647)]
    [Attributes(9)]
    public sealed class MfC1Im2TransconductorValue
    {
        public byte Value { get; set; }
    }
}