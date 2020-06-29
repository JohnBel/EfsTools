using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(361)]
    [Attributes(9)]
    public sealed class VlcdAdcCnt
    {
        public byte Value { get; set; }
    }
}