using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1791)]
    [Attributes(9)]
    public sealed class RfrBbFilter
    {
        public byte Value { get; set; }
    }
}