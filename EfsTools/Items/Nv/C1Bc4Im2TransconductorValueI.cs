using System;
using System.Runtime.InteropServices;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [NvItemId(1532)]
    [Attributes(9)]
    public sealed class C1Bc4Im2TransconductorValue
    {
        public byte Value { get; set; }
    }
}