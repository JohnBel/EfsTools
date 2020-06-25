using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(2762)]
    [Attributes(9)]
    public sealed class GsmAmamArfcnF2
    {
        public ushort Value { get; set; }
    }
}