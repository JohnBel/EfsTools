using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(632)]
    [Attributes(9)]
    public sealed class PcsRxfFgQoffset
    {
        public uint Value { get; set; }
    }
}