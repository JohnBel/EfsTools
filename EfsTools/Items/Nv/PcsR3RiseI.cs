using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(341)]
    [Attributes(9)]
    public sealed class PcsR3Rise
    {
        public byte Value { get; set; }
    }
}