using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4103)]
    [Attributes(9)]
    public sealed class RtrBbFilter
    {
        public byte Value { get; set; }
    }
}