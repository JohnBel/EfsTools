using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(389)]
    [Attributes(9)]
    public sealed class PcsLnaRange12Offset
    {
        public short Value { get; set; }
    }
}