using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(977)]
    [Attributes(9)]
    public sealed class C1PcsVgaGainOffset
    {
        public short Value { get; set; }
    }
}