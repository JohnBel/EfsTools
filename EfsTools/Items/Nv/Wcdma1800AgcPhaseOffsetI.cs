using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(2872)]
    [Attributes(9)]
    public sealed class Wcdma1800AgcPhaseOffset
    {
        public byte Value { get; set; }
    }
}