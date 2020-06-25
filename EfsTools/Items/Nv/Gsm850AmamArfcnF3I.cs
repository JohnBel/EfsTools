using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(3144)]
    [Attributes(9)]
    public sealed class Gsm850AmamArfcnF3
    {
        public ushort Value { get; set; }
    }
}