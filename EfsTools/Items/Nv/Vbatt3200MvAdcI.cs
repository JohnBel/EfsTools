using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(810)]
    [Attributes(9)]
    public sealed class Vbatt3200MvAdc
    {
        public ushort Value { get; set; }
    }
}