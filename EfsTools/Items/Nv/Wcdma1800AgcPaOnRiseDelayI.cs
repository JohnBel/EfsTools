using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(2901)]
    [Attributes(9)]
    public sealed class Wcdma1800AgcPaOnRiseDelay
    {
        public ushort Value { get; set; }
    }
}