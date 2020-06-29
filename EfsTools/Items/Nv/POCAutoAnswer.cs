using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(3189)]
    [Attributes(9)]
    public sealed class PocAutoAnswer
    {
        public byte Value { get; set; }
    }
}