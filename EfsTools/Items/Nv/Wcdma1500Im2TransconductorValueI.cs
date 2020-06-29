using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6923)]
    [Attributes(9)]
    public sealed class Wcdma1500Im2TransconductorValue
    {
        public byte Value { get; set; }
    }
}