using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(2778)]
    [Attributes(9)]
    public sealed class GsmBasebandBwVal
    {
        public byte Value { get; set; }
    }
}