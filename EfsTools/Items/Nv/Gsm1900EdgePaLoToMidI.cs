using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(5392)]
    [Attributes(9)]
    public sealed class Gsm1900EdgePaLoToMid
    {
        public ushort Value { get; set; }
    }
}