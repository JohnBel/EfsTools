using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(3397)]
    [Attributes(9)]
    public sealed class Gsm850PrechargeDur
    {
        public ushort Value { get; set; }
    }
}