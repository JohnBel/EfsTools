using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(502)]
    [Attributes(9)]
    public sealed class Ant2LnaRange12Offset
    {
        public short Value { get; set; }
    }
}