using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(816)]
    [Attributes(9)]
    public sealed class DcsPrechargeDur
    {
        public ushort Value { get; set; }
    }
}