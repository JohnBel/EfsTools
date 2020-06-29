using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(2902)]
    [Attributes(9)]
    public sealed class Wcdma1800AgcPaOnFallDelay
    {
        public ushort Value { get; set; }
    }
}