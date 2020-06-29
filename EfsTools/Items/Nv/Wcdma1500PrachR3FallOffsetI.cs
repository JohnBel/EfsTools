using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6988)]
    [Attributes(9)]
    public sealed class Wcdma1500PrachR3FallOffset
    {
        public short Value { get; set; }
    }
}