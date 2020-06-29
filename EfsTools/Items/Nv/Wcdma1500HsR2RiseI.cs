using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(7049)]
    [Attributes(9)]
    public sealed class Wcdma1500HsR2Rise
    {
        public short Value { get; set; }
    }
}