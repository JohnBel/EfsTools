using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(251)]
    [Attributes(9)]
    public sealed class Pdm1
    {
        public byte Value { get; set; }
    }
}