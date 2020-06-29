using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(562)]
    [Attributes(9)]
    public sealed class PreferredHybridMode
    {
        public byte Value { get; set; }
    }
}