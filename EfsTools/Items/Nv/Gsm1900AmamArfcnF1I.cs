using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(2761)]
    [Attributes(9)]
    public sealed class Gsm1900AmamArfcnF1
    {
        public ushort Value { get; set; }
    }
}