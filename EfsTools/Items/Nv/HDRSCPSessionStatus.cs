using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(475)]
    [Attributes(9)]
    public sealed class HdrScpSessionStatus
    {
        public ushort Value { get; set; }
    }
}