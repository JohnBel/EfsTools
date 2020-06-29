using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6986)]
    [Attributes(9)]
    public sealed class Wcdma1500PrachR2FallOffset
    {
        public short Value { get; set; }
    }
}