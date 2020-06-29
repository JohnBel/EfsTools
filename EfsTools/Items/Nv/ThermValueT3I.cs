using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(4223)]
    [Attributes(9)]
    public sealed class ThermValueT3
    {
        public sbyte Value { get; set; }
    }
}