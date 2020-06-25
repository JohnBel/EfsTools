using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(7211)]
    [Attributes(9)]
    public sealed class C1WcdmaDc1LnaRangeOffset3Car1
    {
        public short Value { get; set; }
    }
}