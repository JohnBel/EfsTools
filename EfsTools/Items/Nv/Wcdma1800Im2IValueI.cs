using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(2858)]
    [Attributes(9)]
    public sealed class Wcdma1800Im2IValue
    {
        public byte Value { get; set; }
    }
}