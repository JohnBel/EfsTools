using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1427)]
    [Attributes(9)]
    public sealed class C0Bc5Im2TransconductorValue
    {
        public byte Value { get; set; }
    }
}