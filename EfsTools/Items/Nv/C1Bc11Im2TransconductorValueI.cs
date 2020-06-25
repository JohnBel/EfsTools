using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(3917)]
    [Attributes(9)]
    public sealed class C1Bc11Im2TransconductorValue
    {
        public byte Value { get; set; }
    }
}