using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(7056)]
    [Attributes(9)]
    public sealed class Wcdma1500HsLnaRangeFall
    {
        public short Value { get; set; }
    }
}