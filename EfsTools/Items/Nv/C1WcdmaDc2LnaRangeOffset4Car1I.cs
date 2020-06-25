using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(7214)]
    [Attributes(9)]
    public sealed class C1WcdmaDc2LnaRangeOffset4Car1
    {
        public short Value { get; set; }
    }
}