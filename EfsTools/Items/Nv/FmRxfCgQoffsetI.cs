using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(625)]
    [Attributes(9)]
    public sealed class FmRxfCgQoffset
    {
        public uint Value { get; set; }
    }
}