using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(694)]
    [Attributes(9)]
    public sealed class PcsVgaGainOffset
    {
        public short Value { get; set; }
    }
}