using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(3142)]
    [Attributes(9)]
    public sealed class GsmAmamArfcnF3
    {
        public ushort Value { get; set; }
    }
}