using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4257)]
    [Attributes(9)]
    public sealed class RfpMicConfiguration
    {
        public byte Value { get; set; }
    }
}