using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(929)]
    [Attributes(9)]
    public sealed class PzidHysterisisTimer
    {
        public ushort Value { get; set; }
    }
}