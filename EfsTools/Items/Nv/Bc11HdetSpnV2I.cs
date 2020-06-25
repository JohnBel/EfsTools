using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(5765)]
    [Attributes(9)]
    public sealed class Bc11HdetSpnV2
    {
        public ushort Value { get; set; }
    }
}