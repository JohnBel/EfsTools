using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4224)]
    [Attributes(9)]
    public sealed class ThermValueT4
    {
        public sbyte Value { get; set; }
    }
}