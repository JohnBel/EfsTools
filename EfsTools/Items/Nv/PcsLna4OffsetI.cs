using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(603)]
    [Attributes(9)]
    public sealed class PcsLna4Offset
    {
        public short Value { get; set; }
    }
}