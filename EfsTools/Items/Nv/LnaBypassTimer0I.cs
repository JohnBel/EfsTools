using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(843)]
    [Attributes(9)]
    public sealed class LnaBypassTimer0
    {
        public ushort Value { get; set; }
    }
}