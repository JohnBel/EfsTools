using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(6946)]
    [Attributes(9)]
    public sealed class Wcdma1500R1Rise
    {
        public ushort Value { get; set; }
    }
}