using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(2764)]
    [Attributes(9)]
    public sealed class Gsm850AmamArfcnF2
    {
        public ushort Value { get; set; }
    }
}