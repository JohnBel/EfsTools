using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(362)]
    [Attributes(9)]
    public sealed class VlcdDrvrCnt
    {
        public byte Value { get; set; }
    }
}