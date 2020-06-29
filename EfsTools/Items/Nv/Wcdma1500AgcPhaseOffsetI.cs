using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6937)]
    [Attributes(9)]
    public sealed class Wcdma1500AgcPhaseOffset
    {
        public byte Value { get; set; }
    }
}