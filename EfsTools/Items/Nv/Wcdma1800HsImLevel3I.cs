using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4756)]
    [Attributes(9)]
    public sealed class Wcdma1800HsImLevel3
    {
        public short Value { get; set; }
    }
}