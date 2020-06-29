using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(620)]
    [Attributes(9)]
    public sealed class PcsRxfCgIoffset
    {
        public uint Value { get; set; }
    }
}