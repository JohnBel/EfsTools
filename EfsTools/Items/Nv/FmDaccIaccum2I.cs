using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(653)]
    [Attributes(9)]
    public sealed class FmDaccIaccum2
    {
        public byte Value { get; set; }
    }
}