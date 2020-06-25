using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(3070)]
    [Attributes(9)]
    public sealed class GsmPaEnStop
    {
        public short Value { get; set; }
    }
}