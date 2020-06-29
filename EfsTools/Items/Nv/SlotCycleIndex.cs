using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(5)]
    [Attributes(9)]
    public sealed class SlotCycleIndex
    {
        public byte Value { get; set; }
    }
}