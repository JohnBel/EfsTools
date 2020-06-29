using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(2859)]
    [Attributes(9)]
    public sealed class Wcdma1800Im2QValue
    {
        public byte Value { get; set; }
    }
}