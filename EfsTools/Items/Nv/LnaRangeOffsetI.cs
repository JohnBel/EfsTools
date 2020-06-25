using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(159)]
    [Attributes(9)]
    public sealed class LnaRangeOffset
    {
        public ushort Value { get; set; }
    }
}