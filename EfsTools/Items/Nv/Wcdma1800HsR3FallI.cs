using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(2944)]
    [Attributes(9)]
    public sealed class Wcdma1800HsR3Fall
    {
        public short Value { get; set; }
    }
}