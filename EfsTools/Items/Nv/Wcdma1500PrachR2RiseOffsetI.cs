using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6985)]
    [Attributes(9)]
    public sealed class Wcdma1500PrachR2RiseOffset
    {
        public short Value { get; set; }
    }
}