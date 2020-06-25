using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(815)]
    [Attributes(9)]
    public sealed class GsmPrechargeDur
    {
        public ushort Value { get; set; }
    }
}